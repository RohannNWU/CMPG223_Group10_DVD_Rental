/*
 * CMPG223 Project - G10 DVD Rentals
 * Date Created: 03/08/2024
 * Rohann Venter, 25130757
 * Jacques van Heerden, 35317906 
 * Francois Verster, 40723380
 * Stefan Venter, 39066894
 * Christo Prinsloo, 21052239
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CMPG223_Group10_DVD_Rental
{
    public partial class DashboardForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DVDRentalShop.mdf;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        private string sqlQuery;
        private List<string> originalMembers = new List<string>();
        private List<string> originalDVD = new List<string>();
        private string name;
        private string role;
        private int employeeID;
        private const decimal LATE_FEE = 3.0M;
        private decimal totalFine = 0.0M;
        private int clientID;
        private bool alreadyRented = false;
        private string fineClient;
        private int fineID;
        private int fineDVD;
        public DashboardForm()
        {
            InitializeComponent();
        }

        public DashboardForm(string name, string role, int employeeID)
        {
            InitializeComponent();
            this.name = name;
            this.role = role;
            this.employeeID = employeeID;
            
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            empLabel.Text = "Employee Logged in: " + name + ", (" + role + ")";

            //Populate Member comboBox
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                sqlQuery = "SELECT Client_ID, Client_Name_Surname FROM Client";
                command = new SqlCommand(sqlQuery, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbMember.Items.Add(reader.GetValue(0).ToString() +"-"+ reader.GetValue(1).ToString());
                }
                conn.Close();
                originalMembers = cmbMember.Items.Cast<string>().ToList();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Couldn't connect to database. " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (cmbDVD.Text.Contains("-Out of Stock"))
            {
                MessageBox.Show("Please choose another DVD. The current one is out of stock");
            } else
            {
                foreach (string dvd in returnComboBox.Items.Cast<string>().ToList())
                {
                    if (cmbDVD.Text.Contains(dvd))
                    {
                        alreadyRented = true;
                        MessageBox.Show("Cannot rent the same DVD again.");
                        return;
                    }
                }

                // verifies if the member already has rented the dvd
                if (alreadyRented == false)
                {
                    //Add new Rental
                    try
                    {
                        // inserts the new rental to the rental table
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Rental (Employee_ID, Client_ID, DVD_ID, Start_Date, Return_Date) VALUES (@Employee_ID, @Client_ID, @DVD_ID, @Start_Date, @Return_Date)", conn);
                        cmd.Parameters.AddWithValue("@Employee_ID", employeeID);
                        cmd.Parameters.AddWithValue("@Client_ID", clientID);
                        string selectedItem = cmbDVD.Text;
                        int DVD_ID;

                        if (selectedItem.Contains("-"))
                        {
                            string[] parts = selectedItem.Split('-');
                            DVD_ID = int.Parse(parts[0]);
                        }
                        else
                        {
                            DVD_ID = int.Parse(selectedItem);
                        }
                        cmd.Parameters.AddWithValue("@DVD_ID", DVD_ID);
                        cmd.Parameters.AddWithValue("@Start_Date", DateTime.Today);
                        cmd.Parameters.AddWithValue("@Return_Date", DateTime.Today.AddDays(14));
                        cmd.ExecuteNonQuery();

                        // fetch the available copies of the dvd rented to decrement
                        sqlQuery = "SELECT DVD_Copies FROM DVD WHERE DVD_ID = @id";
                        SqlCommand comm = new SqlCommand(sqlQuery, conn);
                        comm.Parameters.AddWithValue("@id", DVD_ID);
                        SqlDataReader dataReader = comm.ExecuteReader();
                        int copies = 0;
                        while (dataReader.Read())
                        {
                            copies = (int)dataReader["DVD_Copies"];
                            copies--;
                        }
                        dataReader.Close();

                        // update the available copies in dvd table
                        sqlQuery = "UPDATE DVD SET DVD_Copies = @copies WHERE DVD_ID = @id";
                        SqlCommand com = new SqlCommand(sqlQuery, conn);
                        com.Parameters.AddWithValue("@copies", copies);
                        com.Parameters.AddWithValue("@id", DVD_ID);
                        com.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Rental successfully added to the database.");
                        ResetPage();
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("SQL Error: " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void cmbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            rentingGroupBox.Visible = false;
            returnGroupBox.Visible = false;
            gbOutstandingDVD.Visible = false;
            cmbDVD.Items.Clear();
            //Save Client ID in Variable
            string selectedItem = cmbMember.Text;    
            string[] parts = selectedItem.Split('-');
            if (int.TryParse(parts[0], out clientID)) {
                PopulateDVDs(clientID);
            }
        }

        private void PopulateDVDs(int clientID)
        {
            cmbDVD.Items.Clear();
            outstandingDVDsListView.Items.Clear();
            conn = new SqlConnection(connectionString);
            try
            {
                //Populate DVD comboBox with DVD IDs
                conn.Open();
                command = new SqlCommand(@"SELECT DVD_ID, DVD_Name, DVD_Copies FROM DVD", conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetValue(2).ToString() == "0")
                    {
                        cmbDVD.Items.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1) + "-Out of Stock");
                    }
                    else
                    {
                        cmbDVD.Items.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString() + "-" + reader.GetValue(2));
                    }
                }
                rentingGroupBox.Visible = true;
                reader.Close();
                originalDVD = cmbDVD.Items.Cast<string>().ToList();
                conn.Close();

                // check for outstanding or late Returns
                conn.Open();
                command = new SqlCommand(@"SELECT DVD_ID,Start_Date,Return_Date FROM Rental WHERE Client_ID = @ID", conn);
                command.Parameters.AddWithValue("@ID", clientID);
                reader = command.ExecuteReader();
                SqlConnection local = new SqlConnection(connectionString);
                while (reader.Read())
                {
                    local.Open();
                    command = new SqlCommand(@"SELECT DVD_Name FROM DVD WHERE DVD_ID = @ID", local);
                    command.Parameters.AddWithValue("@ID", reader.GetValue(0));
                    SqlDataReader dataReader = command.ExecuteReader();
                    int counter = 1;

                    while (dataReader.Read())
                    {
                        //Calculate and display fine
                        TimeSpan difference = DateTime.Today - reader.GetDateTime(2);
                        int daysPastDue = (int)difference.TotalDays;
                        if (daysPastDue > 0)
                        {
                            rentingGroupBox.Visible = false;
                            decimal penalty = daysPastDue > 0 ? daysPastDue * LATE_FEE : 0;
                            totalFine += penalty;
                            outstandingDVDsListView.Items.Clear();
                            outstandingDVDsListView.Columns.Clear();
                            outstandingDVDsListView.View = View.Details;
                            outstandingDVDsListView.Columns.Add("DVD Name", 100, HorizontalAlignment.Left);
                            outstandingDVDsListView.Columns.Add("Start Date", 100, HorizontalAlignment.Left);
                            outstandingDVDsListView.Columns.Add("Due Date", 100, HorizontalAlignment.Left);
                            outstandingDVDsListView.Columns.Add("Fine Due", 100, HorizontalAlignment.Left);
                            ListViewItem item = new ListViewItem(counter.ToString() + "." + dataReader.GetValue(0).ToString());
                            item.SubItems.Add(reader.GetDateTime(1).ToString("yyyy/MM/dd"));
                            item.SubItems.Add(reader.GetDateTime(2).ToString("yyyy/MM/dd"));
                            item.SubItems.Add(penalty.ToString("C"));
                            outstandingDVDsListView.Items.Add(item);
                            lblFine.Text = "Fine Due: " + totalFine.ToString("C");
                            fineDVD = (int)reader.GetValue(0);
                            fineID = clientID;
                            gbOutstandingDVD.Visible = true;
                        }
                        else
                        {
                            RefreshDVD();
                            returnGroupBox.Visible = true;
                        }
                        counter++;
                    }
                    dataReader.Close();
                    local.Close();
                }
                reader.Close();
                conn.Close();
                cmbDVD.SelectedIndex = 0;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbDVD_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            lblToday.Text = "Today's Date: " + today.ToString("yyyy/MM/dd");
            DateTime returnDate = today.AddDays(14);
            lblReturnDate.Text = "Return Date: " + returnDate.ToString("yyyy/MM/dd");
        }
        private void ResetPage()
        {
            cmbDVD.Items.Clear();
            lblToday.Text = "Today's Date: ";
            lblReturnDate.Text = "Return Date: ";
            lblFine.Text = "Fine Due: ";
            outstandingDVDsListView.Items.Clear();
            returnComboBox.Items.Clear();
            cmbMember.SelectedIndex = -1;
            totalFine = 0.0M;
            rentingGroupBox.Visible = false;
            returnGroupBox.Visible = false;
        }


        private void cmbDVD_TextUpdate(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            string searchText = cmb.Text;
            cmb.TextUpdate -= cmbDVD_TextUpdate;
            if (string.IsNullOrEmpty(searchText))
            {
                cmb.Items.Clear();
                cmb.Items.AddRange(originalDVD.ToArray());
            }
            else
            {
                var filteredItems = originalDVD.Where(item => item.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                cmb.Items.Clear();
                cmb.Items.AddRange(filteredItems.ToArray());
            }
            cmb.Text = searchText;
            cmb.SelectionStart = searchText.Length;
            cmb.SelectionLength = 0;
            cmb.TextUpdate += cmbDVD_TextUpdate;
            if (cmb.Items.Count > 0)
            {
                cmb.DroppedDown = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void cmbMember_TextUpdate(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            string searchText = cmb.Text;
            cmb.TextUpdate -= cmbMember_TextUpdate;
            if (string.IsNullOrEmpty(searchText))
            {
                cmb.Items.Clear();
                cmb.Items.AddRange(originalMembers.ToArray());
            }
            else
            {
                var filteredItems = originalMembers.Where(item => item.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                cmb.Items.Clear();
                cmb.Items.AddRange(filteredItems.ToArray());
            }
            cmb.Text = searchText;
            cmb.SelectionStart = searchText.Length;
            cmb.SelectionLength = 0;
            cmb.TextUpdate += cmbMember_TextUpdate;
            if (cmb.Items.Count > 0)
            {
                cmb.DroppedDown = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            string[] getClient = cmbMember.Text.Split('-');
            fineClient = getClient[1];
            PaymentForm paymentForm = new PaymentForm(fineClient, totalFine);
            paymentForm.ShowDialog();
            
            if (paymentForm.isPaid())
            {
                checkoutButton.Visible = true;
                gbOutstandingDVD.Visible = false;
                rentingGroupBox.Visible = true;

                conn = new SqlConnection(connectionString);

                try
                {
                    // delete the late rental from the rental table
                    conn.Open();
                    sqlQuery = "DELETE FROM Rental WHERE Client_ID = @client AND DVD_ID = @dvd";
                    command = new SqlCommand(sqlQuery, conn);
                    command.Parameters.AddWithValue("@client", fineID);
                    command.Parameters.AddWithValue("@dvd", fineDVD);
                    command.ExecuteNonQuery();
                    conn.Close();

                    // get the amount of copies from DVD table
                    conn.Open();
                    sqlQuery = "SELECT DVD_Copies FROM DVD WHERE DVD_ID = @dvd";
                    command = new SqlCommand(sqlQuery, conn);
                    command.Parameters.AddWithValue("@dvd", fineDVD);
                    reader = command.ExecuteReader();
                    int copies = 0;
                    if (reader.Read()) {
                        copies = (int)reader.GetValue(0);
                        copies++;
                    }
                    reader.Close();
                    conn.Close();

                    // update the copies in the DVD table
                    conn.Open();
                    sqlQuery = "UPDATE DVD SET DVD_Copies = @copies";
                    command = new SqlCommand(sqlQuery, conn);
                    command.Parameters.AddWithValue("@copies", copies);
                    command.ExecuteNonQuery();
                    conn.Close();
                    PopulateDVDs(fineID);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Sql Error. " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. " + ex.Message);
                }
            } else
            {
                totalFine = paymentForm.getFine();
            }
        }

        // return a rental
        private void returnButton_Click(object sender, EventArgs e)
        {
            try
            {
                // delete the rental from the rental table
                conn.Open();
                string[] dvd = returnComboBox.Text.Split('-');
                sqlQuery = "DELETE FROM Rental WHERE Client_ID = @client AND DVD_ID = @dvd";
                command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@client", clientID);
                command.Parameters.AddWithValue("@dvd", dvd[0]);
                command.ExecuteNonQuery();
                conn.Close();

                // fetch the dvd copies available to increment
                conn.Open();
                sqlQuery = "SELECT DVD_Copies FROM DVD WHERE DVD_ID = @dvd";
                command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@dvd", dvd[0]);
                reader = command.ExecuteReader();
                int copies = 0;
                while (reader.Read())
                {
                    copies = (int)reader.GetValue(0);
                    copies++;
                }
                conn.Close();

                // update the copies available and re-populate the combo box
                conn.Open();
                sqlQuery = "UPDATE DVD SET DVD_Copies = @copies WHERE DVD_ID = @id";
                command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@copies", copies);
                command.Parameters.AddWithValue("@id", dvd[0]);
                command.ExecuteNonQuery();
                conn.Close();
                RefreshDVD();
                PopulateDVDs(clientID);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Sql Error. " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }

        }

        private void RefreshDVD()
        {
            SqlConnection refreshConn = new SqlConnection(connectionString);
            SqlDataReader refreshReader;
            try
            {
                returnComboBox.Items.Clear();
                refreshConn.Open();
                sqlQuery = "SELECT DVD_ID FROM Rental WHERE Client_ID = @client";
                command = new SqlCommand(sqlQuery, refreshConn);
                command.Parameters.AddWithValue("@client", clientID);
                refreshReader = command.ExecuteReader();

                if (!refreshReader.HasRows)
                {
                    returnGroupBox.Visible = false;
                }
                else
                {
                    while (refreshReader.Read())
                    {
                        SqlConnection local = new SqlConnection(connectionString);
                        local.Open();
                        sqlQuery = "SELECT DVD_Name FROM DVD WHERE DVD_ID = @id";
                        SqlCommand localCommand = new SqlCommand(sqlQuery, local);
                        localCommand.Parameters.AddWithValue("@id", refreshReader.GetValue(0));
                        SqlDataReader dataReader = localCommand.ExecuteReader();

                        while (dataReader.Read())
                        {
                            returnComboBox.Items.Add(refreshReader.GetValue(0) + "-" + dataReader.GetValue(0));
                        }
                        local.Close();
                    }
                    returnComboBox.SelectedIndex = 0;
                }
                refreshConn.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Sql Error. " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }
    }
}
