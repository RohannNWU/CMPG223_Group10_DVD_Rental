using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CMPG223_Group10_DVD_Rental
{
    public partial class DashboardForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DVDRentalShop.mdf;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        private string sqlQuery;

        private string name;
        private string role;
        private int employeeID;
        private const decimal LATE_FEE = 3.0M;
        private decimal totalFine = 0;
        private int ClientID;
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
            DateTime today = DateTime.Now;
            lblToday.Text = "Today's date: " + today.ToString("yyyy/MM/dd");
            DateTime returnDate = today.AddDays(14);
            lblReturnDate.Text = "Return date: " + returnDate.ToString("yyyy/MM/dd");
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            empLabel.Text = "Employee ID: " + employeeID +  ", Employee Logged in: " + name + ", (" + role + ")";


            //Pupulate Member comboBox
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                sqlQuery = "SELECT Client_ID, Client_Name_Surname FROM CLient";
                command = new SqlCommand(sqlQuery, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbMember.Items.Add(reader.GetValue(0).ToString() +" - "+ reader.GetValue(1).ToString());
                }
                conn.Close();
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

            //Add new Rent
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Rent (Employee_ID, Client_ID, DVD_ID, Start_Date, Return_Date) VALUES (@Employee_ID, @Client_ID, @DVD_ID, @Start_Date, @Return_Date)", conn);

                cmd.Parameters.AddWithValue("@Employee_ID",employeeID);
                cmd.Parameters.AddWithValue("@Client_ID", ClientID);

                string selectedItem = cmbDVD.SelectedItem.ToString();
                int DVD_ID;
                if (selectedItem.Contains("-"))
                {
                    string[] parts = selectedItem.Split('-');
                    DVD_ID = int.Parse(parts[0].Trim());
                }
                else
                {
                    DVD_ID = int.Parse(selectedItem);
                }
                cmd.Parameters.AddWithValue("@DVD_ID", DVD_ID);
                cmd.Parameters.AddWithValue("@Start_Date", DateTime.Today);
                cmd.Parameters.AddWithValue("@Return_Date", DateTime.Today.AddDays(14));

                cmd.ExecuteNonQuery();

                conn.Close();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetPage();

            //Make other input Controls visible
            lblDVD.Visible = true;
            cmbDVD.Visible = true;
            lblToday.Visible = true;
            lblReturnDate.Visible = true;
            gbOutstandingDVD.Visible = true;

          
            //Save Client ID in Variable
            string selectedItem = cmbMember.SelectedItem.ToString();    
            string[] parts = selectedItem.Split('-');          
            ClientID = int.Parse(parts[0].Trim());
            

            //Two connections for two SqlDataReaders
            conn = new SqlConnection(connectionString);
            SqlConnection conn1 = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                conn1.Open();

                //Populare DVD comboBox with DVD IDs
                command = new SqlCommand(@"SELECT DVD_Name, DVD_Copies FROM DVD", conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetValue(1).ToString() == "0")
                    {
                        cmbDVD.Items.Add(reader.GetValue(0).ToString() + " - Out of Stock");
                    }
                    else
                    {
                        cmbDVD.Items.Add(reader.GetValue(0).ToString());
                    }
                }
                reader.Close();

                //Check for Outstanding Returns               
                command = new SqlCommand(@"SELECT DVD_ID,Start_Date,Return_Date FROM Rental WHERE Client_ID = @ID ", conn);
                command.Parameters.AddWithValue("@ID", ClientID);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    SqlCommand command1 = new SqlCommand(@"SELECT DVD_Name FROM DVD WHERE DVD_ID = @ID", conn1);
                    command1.Parameters.AddWithValue("@ID", reader.GetValue(0));
                    SqlDataReader dataReader = command1.ExecuteReader();

                    int counter = 1;
                    
                    while (dataReader.Read())
                    {

                        outstandingDVDsListBox.Items.Add(counter.ToString() + "." + dataReader.GetValue(0));
                        outstandingDVDsListBox.Items.Add("Start Date: " + (reader.GetDateTime(1)).ToString("yyyy/MM/dd"));
                        outstandingDVDsListBox.Items.Add("Due Date: " + (reader.GetDateTime(2)).ToString("yyyy/MM/dd"));


                        //Calulate and display fine
                        TimeSpan difference = DateTime.Today-reader.GetDateTime(2);                        
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
                conn1.Close();

                lblFine.Text = "Fine Due: R" + totalFine.ToString();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            if(totalFine==0)
            {
                checkoutButton.Visible = true;
                gbOutstandingDVD.Visible = false;
            }

        }

        private void cmbDVD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Prevent user from selecting out of stock DVD
            if (cmbDVD.SelectedItem != null && cmbDVD.SelectedItem.ToString().Contains("Out of Stock"))
            {
                MessageBox.Show("This DVD is out of stock and cannot be selected.");
                cmbDVD.SelectedIndex = -1;
            }

        }
        private void ResetPage()
        {
            lblDVD.Visible = false;
            cmbDVD.Visible = false;
            lblToday.Visible = false;
            lblReturnDate.Visible = false;
            gbOutstandingDVD.Visible = false;

            lblToday.Text = "Today's Date: ";
            lblReturnDate.Text = "Return Date: ";
            lblFine.Text = "Fine Due: R";
            outstandingDVDsListBox.Items.Clear();
            checkoutButton.Visible=false;

            cmbDVD.Items.Clear();
            totalFine = 0;
        }

    }
}
