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
using System.Data;
using System.Data.SqlClient;
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

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            inputError.Clear();

            if (rbDelete.Checked)
            {
                gbInput.Text = "Delete Member";
                lblName.Visible = true;
                lblName.Text = "ID to Delete:";
                txtName.Visible = true;
                txtName.Clear();
                lblSurname.Visible = false;
                txtSurname.Visible = false;
                lblDOB.Visible = false;
                txtDOB.Visible = false;
                lblEmail.Visible = false;
                txtEmail.Visible = false;
                memberLabel.Visible = false;
                memberComboBox.Visible = false;
                btnSubmit.Text = "Delete";
                gbInput.Visible = true;
                cmbDelete.Visible = true;
                txtName.Visible = false;

                try
                {
                    conn.Open();
                    command = new SqlCommand(@"SELECT Client_ID FROM Client", conn);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbDelete.Items.Add(reader.GetValue(0).ToString());
                    }
                    conn.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            inputError.Clear();

            if (rbAdd.Checked)
            {
                cmbDelete.Visible=false;
                gbInput.Visible = true;
                gbInput.Text = "Add New Member";
                lblName.Visible = true;
                lblName.Text = "Name:";
                txtName.Clear();
                txtName.Visible = true;
                lblSurname.Visible = true;
                lblSurname.Text = "Surname:";
                txtSurname.Clear();
                txtSurname.Enabled = true;
                txtSurname.Visible = true;
                lblDOB.Visible = true;
                txtDOB.Clear();
                txtDOB.Visible = true;
                lblEmail.Visible = true;
                txtEmail.Clear();
                txtEmail.Visible = true;
                btnSubmit.Text = "Add New Client";
                memberLabel.Visible = false;
                memberComboBox.Visible = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                if (rbAdd.Checked)
                {
                    conn = new SqlConnection(connectionString);
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Client (Client_Name_Surname, Date_of_Birth,Email_Address) VALUES (@NameSurname, @DOB, @Email_Address)", conn);
                        cmd.Parameters.AddWithValue("@NameSurname", txtName.Text + " " + txtSurname.Text);
                        cmd.Parameters.AddWithValue("@DOB", txtDOB.Text);
                        cmd.Parameters.AddWithValue("@Email_Address", txtEmail.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        EmptyInput();
                        memberComboBox.SelectedIndex = -1;
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
                else if (updateRadioButton.Checked)
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
                        memberComboBox.SelectedIndex = -1;
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
                else
                {
                    MessageBox.Show("Please select a database command");
                }
            }
            
            if (ValidateDeleteInput())
            {
                if (rbDelete.Checked)
                {
                    conn = new SqlConnection(connectionString);
                    try
                    {

                        int clientID = int.Parse(cmbDelete.Text);

                        conn.Open();
                        command = new SqlCommand(@"SELECT Client_Name_Surname FROM Client WHERE Client_ID = @Client_ID", conn);
                        command.Parameters.AddWithValue("@Client_ID", clientID);
                        reader = command.ExecuteReader();

                        DialogResult getResult = DialogResult.No;

                        if (reader.Read())
                        {
                             getResult = MessageBox.Show("Are you sure you want to delete: " + reader.GetValue(0).ToString(), "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        }
                        conn.Close();
                       
                        
                        if (getResult == DialogResult.Yes)
                        {
                            conn.Open();

                            command = new SqlCommand(@"DELETE FROM Client WHERE Client_ID = @Client_ID", conn);
                            command.Parameters.AddWithValue("@Client_ID", clientID);
                            command.ExecuteNonQuery();
                            
                            conn.Close();

                            EmptyInput();
                        }
                        

                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Cannot Delete customer due to outstanding DVD.\n\n(SQL error message: " + sqlEx.Message+")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    memberComboBox.SelectedIndex = -1;
                }
            }
            ShowAllData();
            EmptyInput();
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
            cmbDelete.Visible = false;
            cmbDelete.Items.Clear();
            ShowAllData();
        }

        private void updateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            inputError.Clear();

            if (updateRadioButton.Checked == true)
            {
                cmbDelete.Visible = false;
                memberComboBox.Items.Clear();
                gbInput.Text = "Update Member";
                lblName.Visible = true;
                lblName.Text = "Name:";
                txtName.Visible = true;
                lblSurname.Text = "Member ID:";
                lblSurname.Visible = true;
                txtSurname.Enabled = false;
                txtSurname.Visible = true;
                lblDOB.Visible = true;
                txtDOB.Visible = true;
                lblEmail.Visible = true;
                txtEmail.Visible = true;
                memberLabel.Visible = true;
                memberComboBox.Visible = true;
                btnSubmit.Text = "Update";
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
                    memberComboBox.SelectedIndex = -1;
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

        private bool ValidateUserInput()
        {
            bool allInputValid = true;

            foreach (TextBox textBox in new[] { txtName, txtSurname, txtDOB, txtEmail })
            {
                if (String.IsNullOrEmpty(textBox.Text))
                {
                    inputError.SetError(textBox, "Input is required. Cannot be blank");
                    allInputValid = false;
                } else
                {
                    inputError.SetError(textBox, "");
                }
            }
            return allInputValid;
        }

        private bool ValidateDeleteInput()
        {
            bool allValid = true;
            if (String.IsNullOrEmpty(cmbDelete.Text))
            {
                allValid = false;
            }
            return allValid;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }

        private void ascendButton_Click(object sender, EventArgs e)
        {
            DGVCustomer.DataSource = null;
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT * FROM Client ORDER BY Client_Name_Surname ASC", conn);
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

        private void descendButton_Click(object sender, EventArgs e)
        {
            DGVCustomer.DataSource = null;
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT * FROM Client ORDER BY Client_ID ASC", conn);
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

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            DGVCustomer.DataSource = null;
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                sqlQuery = @"SELECT * FROM Client WHERE Client_Name_Surname LIKE @filterText";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@filterText", "%" + filterTextBox.Text + "%");
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
    }
}
