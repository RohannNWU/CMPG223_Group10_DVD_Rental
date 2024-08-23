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
            } else if (updateRadioButton.Checked)
            {
                conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();
                    sqlQuery = "UPDATE Client SET Client_Name_Surname = @name, Date_Of_Birth = @dob, Email_Address = @email WHERE Client_ID = @id";
                    command = new SqlCommand(sqlQuery, conn);
                    command.Parameters.AddWithValue("@id", txtSurname.Text);
                    command.Parameters.AddWithValue("@name", txtName.Text);
                    command.Parameters.AddWithValue("@dob", txtDOB.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                    EmptyInput();
                    memberComboBox.Items.Clear();
                    memberComboBox.Visible = false;
                    memberLabel.Visible = false;
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
            else
            {
                MessageBox.Show("Please select a database command");
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
            updateRadioButton.Checked = false;

            ShowAllData();
        }

        private void updateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRadioButton.Checked == true)
            {
                memberLabel.Visible = true;
                memberComboBox.Visible = true;
                btnSubmit.Text = "Update";
                gbInput.Text = "Update Member";
                lblSurname.Text = "Member ID:";
                txtSurname.Enabled = false;
                gbInput.Visible = true;

                conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();
                    sqlQuery = "SELECT Client_ID, Client_Name_Surname FROM Client";
                    command = new SqlCommand(sqlQuery, conn);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        memberComboBox.Items.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString());
                    }
                    memberComboBox.SelectedIndex = 0;
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
        }

        private void memberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getName = memberComboBox.SelectedItem.ToString();
            string name = getName.Substring(3);

            txtName.Text = name;

            conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                sqlQuery = "SELECT * FROM Client WHERE Client_Name_Surname = @name";
                command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@name", name);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtSurname.Text = reader.GetValue(0).ToString();
                    txtName.Text = reader.GetValue(1).ToString();
                    txtDOB.Text = Convert.ToDateTime(reader.GetValue(2)).ToString("yyyy-MM-dd");
                    txtEmail.Text = reader.GetValue(3).ToString();
                }
                conn.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Couldn't connect to database. " + sqlEx.Message);
            }
            catch (Exception ex) {
                MessageBox.Show("Error. " + ex.Message);
            }
        }
    }
}
