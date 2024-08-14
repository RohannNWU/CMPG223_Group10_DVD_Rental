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

namespace CMPG223_Group10_DVD_Rental
{
    public partial class Customer : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DVDRentalShop.mdf;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        private string sqlQuery;
        public Customer()
        {
            InitializeComponent();
            ShowAllData();
        }

        //Method to show all data in Client table
        public void ShowAllData()
        {
            DGVCustomer.DataSource = null;
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT * FROM Client", conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                DGVCustomer.DataSource = dataTable;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void rbEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEdit.Checked)
            {
                gbInput.Visible = true;
            }
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {

            if (rbDelete.Checked)
            {
                gbInput.Visible = true;
                gbInput.Visible = true;
                lblName.Text = "ID to delete: ";

                //Hide unused input controls
                lblDOB.Visible = false;
                txtDOB.Visible = false;
                lblEmail.Visible = false;
                txtEmail.Visible = false;
                lblSurname.Visible = false;
                txtSurname.Visible = false;
            }
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdd.Checked)
            {
                gbInput.Visible = true;
            }
            

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbAdd.Checked)
            {
                conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Client (Client_Name_Surname, Date_of_Birth,Email_Address) VALUES (@NameSurname, @DOB, @Email_Address)", conn);

                    cmd.Parameters.AddWithValue("@NameSurname", txtName.Text + txtSurname.Text);
                    cmd.Parameters.AddWithValue("@DOB", txtDOB.Text);
                    cmd.Parameters.AddWithValue("@Email_Address", txtEmail.Text);
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
            }
            else if (rbDelete.Checked)
            {
                conn = new SqlConnection(connectionString);
                try
                {
                    int ClientId = int.Parse(txtName.Text);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"DELETE FROM Client WHERE Client_ID = @Client_ID", conn);
                    cmd.Parameters.AddWithValue("@Client_ID", ClientId);
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
            }
            else if (rbEdit.Checked)
            {
                conn = new SqlConnection(connectionString);
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
            }
            else
            {
                MessageBox.Show("Please select a databse command");
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
            txtEmail.Text = "";
            txtEmail.Visible = true;
            lblEmail.Visible = true;

            gbInput.Visible = false;

            rbAdd.Checked = false;
            rbDelete.Checked = false;
            rbEdit.Checked = false;

            ShowAllData();
        }
    }
}
