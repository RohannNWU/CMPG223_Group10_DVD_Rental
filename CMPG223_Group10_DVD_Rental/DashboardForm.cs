using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make other input Controls visible
            lblDVD.Visible = true;
            cmbDVD.Visible = true;
            lblToday.Visible = true;
            lblReturnDate.Visible = true;
            gbOutstandingDVD.Visible = true;

            ClientID = cmbMember.SelectedIndex;
            
            try
            {
                conn.Open();

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
                
                command = new SqlCommand(@"SELECT DVD_ID FROM Rental WHERE Client_ID = @ID ", conn);
                command.Parameters.AddWithValue("@ID", ClientID);
                reader = command.ExecuteReader();

               
                if (reader.Read())
                {
                    int[] ARRDVD = 
                    SqlCommand command1 = new SqlCommand(@"SELECT DVD_Name FROM DVD WHERE DVD_ID = @ID ", conn);
                    command1.Parameters.AddWithValue("@ID", reader.GetValue(0));
                    SqlDataReader dataReader = command1.ExecuteReader();
                    while (dataReader.Read())
                    {
                        outstandingDVDsListBox.Items.Add(dataReader.GetValue(0));
                    }
                    
                }


                    conn.Close();


            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //TO-DO: Check if the member has outstanding DVDs in Rental Table, display outstanding groupbox

            // calculate the fine
            //SqlDataReader reader;
            //DateTime returnDate = reader.GetValue(5);
            //DateTime today = DateTime.Now;
            //int finedDays = today.Day - returnDate.Day;
            //decimal fine = LATE_FEE * finedDays;
            //fineLabel.Text = "Fine Due: " + fine.ToString("C");

            //"SELECT DVD_Name, DVD_Copies FROM DVD";

            //if (reader.GetValue(1) == 0)
            //{
            //    dvdComboBox.Items.Add(reader.GetValue(0).ToString() + " - Out of Stock");
            //}

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
            outstandingDVDsListBox.Text = "";

            cmbMember.Items.Clear();
            cmbDVD.Items.Clear();
        }

    }
}
