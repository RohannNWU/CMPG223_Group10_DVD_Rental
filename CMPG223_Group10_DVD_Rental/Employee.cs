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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMPG223_Group10_DVD_Rental
{
    public partial class Employee : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DVDRentalShop.mdf;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        private string sqlQuery;


        public Employee()
        {
            InitializeComponent();
            ShowAllData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAllData();
        }

        //Method to show all data in Employee table
        public void ShowAllData()
        {
            DGVEmployee.DataSource = null;
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT * FROM Employee", conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                DGVEmployee.DataSource = dataTable;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void cmbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select index
            gbInput.Visible = true;

            int selectedIndex = cmbCommand.SelectedIndex;

            switch(selectedIndex)
            {
                case 1:
                    lblName.Text = "ID to Delete: ";

                    //Make redundant controls invisible 
                    txtSurname.Visible = false;
                    lblSurname.Visible = false;
                    txtDOB.Visible = false;
                    lblDOB.Visible = false;
                    txtContactNumber.Visible = false;
                    lblContactNumber.Visible = false;
                    txtUsername.Visible = false;
                    lblUserName.Visible = false;
                    txtPassword.Visible = false;
                    lblPassword.Visible = false;
                    cbAdmin.Visible = false;

                    break;
                default:
                    break;

            }
        }

        //Method reset input controls
        private void EmptyInput()
        {
            lblName.Text = "Name:";
            txtName.Text = "";
            txtName.Visible = true;
            lblName.Visible = true;
            txtSurname.Text = "";
            txtSurname.Visible = true;
            lblSurname.Visible = true;
            txtDOB.Text = "";
            txtDOB.Visible = true;
            lblDOB.Visible = true;
            txtContactNumber.Text = "";
            txtContactNumber.Visible = true;
            lblContactNumber.Visible = true;
            txtUsername.Text = "";
            txtUsername.Visible = true;
            lblUserName.Visible = true;
            txtPassword.Text = "";
            txtPassword.Visible = true;
            lblPassword.Visible = true;
            cbAdmin.Checked = false;
            cbAdmin.Visible = true;

            gbInput.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(connectionString);

            int selectedIndex = cmbCommand.SelectedIndex;

            switch (selectedIndex)
            {
                //Update Data according to input
                case 0:
                    gbInput.Visible = true;
                    try
                    {
                        conn.Open();

                        conn.Close();
                        EmptyInput();
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("SQL Error: " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    break;

                // Delete Data
                case 1:
                    gbInput.Visible = true;

                    int employeeId = int.Parse(txtName.Text);
                    try
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(@"DELETE FROM Employee WHERE Employee_ID = @Employee_ID", conn);
                        cmd.Parameters.AddWithValue("@Employee_ID", employeeId);
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        EmptyInput();
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("SQL Error: " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }


                    break;

                //Add new records
                case 2:

                    gbInput.Visible = true;
                    try
                    {

                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("SQL Error: " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    break;

                default:
                    break;
            }

            EmptyInput();
            gbInput.Visible = false;
        }
    }
}
