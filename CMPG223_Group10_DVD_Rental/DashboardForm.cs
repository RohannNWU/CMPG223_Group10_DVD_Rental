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
        private decimal totalFine = 0;
        private int clientID;
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
            empLabel.Text = "Employee ID: " + employeeID +  ", Employee Logged in: " + name + ", (" + role + ")";

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
            //Add new Rental
            try
            {
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

        private void cmbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDVD.Items.Clear();
            //Save Client ID in Variable
            string selectedItem = cmbMember.Text;    
            string[] parts = selectedItem.Split('-');
            if (int.TryParse(parts[0], out clientID)) {
                //Two connections for two SqlDataReaders
                conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    //Populate DVD comboBox with DVD IDs
                    command = new SqlCommand(@"SELECT DVD_ID, DVD_Name, DVD_Copies FROM DVD", conn);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetValue(1).ToString() == "0")
                        {
                            cmbDVD.Items.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString() + "-Out of Stock");
                        }
                        else
                        {
                            cmbDVD.Items.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString() + "-" + reader.GetValue(2).ToString());
                        }
                    }
                    reader.Close();
                    originalDVD = cmbDVD.Items.Cast<string>().ToList();
                    //Check for Outstanding Returns               
                    command = new SqlCommand(@"SELECT DVD_ID,Start_Date,Return_Date FROM Rental WHERE Client_ID = @ID ", conn);
                    command.Parameters.AddWithValue("@ID", clientID);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        SqlCommand command1 = new SqlCommand(@"SELECT DVD_Name FROM DVD WHERE DVD_ID = @ID", conn);
                        command1.Parameters.AddWithValue("@ID", reader.GetValue(0));
                        SqlDataReader dataReader = command1.ExecuteReader();
                        int counter = 1;

                        while (dataReader.Read())
                        {
                            outstandingDVDsListBox.Items.Add(counter.ToString() + "." + dataReader.GetValue(0));
                            outstandingDVDsListBox.Items.Add("Start Date: " + (reader.GetDateTime(1)).ToString("yyyy/MM/dd"));
                            outstandingDVDsListBox.Items.Add("Due Date: " + (reader.GetDateTime(2)).ToString("yyyy/MM/dd"));

                            //Calculate and display fine
                            TimeSpan difference = DateTime.Today - reader.GetDateTime(2);
                            int daysPastDue = (int)difference.TotalDays;
                            decimal penalty = daysPastDue > 0 ? daysPastDue * 30 : 0;
                            totalFine += penalty;

                            outstandingDVDsListBox.Items.Add("Fine: R" + penalty.ToString());
                            outstandingDVDsListBox.Items.Add("==================================================");
                            counter++;
                        }
                        dataReader.Close();
                    }
                    reader.Close();
                    conn.Close();

                    //Make other input Controls visible
                    lblDVD.Visible = true;
                    cmbDVD.Visible = true;
                    lblFine.Text = "Fine Due: " + totalFine.ToString();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                if (totalFine == 0)
                {
                    checkoutButton.Visible = true;
                    gbOutstandingDVD.Visible = false;
                }
            }
        }

        private void cmbDVD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Prevent user from selecting out of stock DVD
            if (cmbDVD.Text.Contains("Out of Stock"))
            {
                MessageBox.Show("This DVD is out of stock and cannot be selected.");
                cmbDVD.SelectedIndex = -1;
            } else
            {
                DateTime today = DateTime.Now;
                lblToday.Text = "Today's Date: " + today.ToString("yyyy/MM/dd");
                lblToday.Visible = true;
                DateTime returnDate = today.AddDays(14);
                lblReturnDate.Text = "Return Date: " + returnDate.ToString("yyyy/MM/dd");
                lblReturnDate.Visible = true;
            }
        }
        private void ResetPage()
        {
            MessageBox.Show("Here");
            lblDVD.Visible = false;
            cmbDVD.Items.Clear();
            cmbDVD.Visible = false;
            lblToday.Visible = false;
            lblReturnDate.Visible = false;
            gbOutstandingDVD.Visible = false;
            lblToday.Text = "Today's Date: ";
            lblReturnDate.Text = "Return Date: ";
            lblFine.Text = "Fine Due: ";
            outstandingDVDsListBox.Items.Clear();
            checkoutButton.Visible = false;
            cmbMember.SelectedIndex = -1;
            totalFine = 0;
        }

        private void payButton_Click(object sender, EventArgs e)
        {

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
    }
}
