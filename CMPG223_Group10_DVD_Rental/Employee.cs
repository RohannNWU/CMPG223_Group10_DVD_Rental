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
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPG223_Group10_DVD_Rental
{
    public partial class Employee : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DVDRentalShop.mdf;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        private string sqlQuery;
        private string employeeRole;

        public Employee()
        {
            InitializeComponent();
            ShowAllData();
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
            inputError.Clear();
            int selectedIndex = cmbCommand.SelectedIndex;
            employeeComboBox.Items.Clear();
            employeeComboBox.Visible = false;
            EmptyInput();

            switch (selectedIndex)
            {
                case 0:
                    employeeLabel.Visible = true;
                    employeeComboBox.Visible = true;
                    gbInput.Text = "Update Employee";
                    
                    conn = new SqlConnection(connectionString);
                    try
                    {
                        conn.Open();
                        sqlQuery = "SELECT Employee_ID, Employee_Name_Surname FROM Employee";
                        command = new SqlCommand(sqlQuery, conn);
                        reader = command.ExecuteReader();

                        while (reader.Read()) {
                            employeeComboBox.Items.Add(reader.GetValue(0).ToString() + ", " + reader.GetValue(1).ToString());
                        }
                        conn.Close();
                        employeeComboBox.SelectedIndex = -1;
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Couldn't connect to database. " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error. " + ex.Message);
                    }

                    break;
                case 1:
                    employeeLabel.Visible = false;
                    employeeComboBox.Visible = false;
                    lblName.Text = "ID to Delete: ";
                    txtName.Clear();
                    txtName.Visible = true;                    
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
                    btnSubmit.Text = "Delete";
                    gbInput.Text = "Delete Employee";
                    gbInput.Visible = true;
                    employeeComboBox.SelectedIndex = -1;
                    txtName.Visible=false;

                    cmbDelete.Visible = true;

                    try
                    {
                        conn.Open();
                        command = new SqlCommand(@"SELECT Employee_ID FROM Employee", conn);
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

                    break;
                case 2:
                    employeeLabel.Visible = false;
                    employeeComboBox.Visible = false;
                    lblName.Text = "Name:";
                    txtName.Clear();
                    txtName.Visible = true;
                    lblSurname.Text = "Surname:";
                    lblSurname.Visible = true;
                    txtSurname.Enabled = true;
                    txtSurname.Clear();
                    txtSurname.Visible = true;
                    lblDOB.Visible = true;
                    txtDOB.Clear();
                    txtDOB.Visible = true;
                    lblContactNumber.Visible = true;
                    txtContactNumber.Clear();
                    txtContactNumber.Visible = true;
                    lblUserName.Visible = true;
                    txtUsername.Clear();
                    txtUsername.Visible = true;
                    lblPassword.Visible = true;
                    txtPassword.Clear();
                    txtPassword.Visible = true;
                    cbAdmin.Checked = false;
                    cbAdmin.Visible = true;
                    btnSubmit.Text = "Add New";
                    gbInput.Text = "Add New Employee";
                    gbInput.Visible = true;
                    employeeComboBox.SelectedIndex = -1;
                    cmbDelete.Visible = false;
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
            cmbDelete.Visible = false;
            cmbDelete.SelectedIndex = -1;
            cmbDelete.Items.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                conn = new SqlConnection(connectionString);
                int selectedIndex = cmbCommand.SelectedIndex;

                switch (selectedIndex)
                {
                    //Update Data according to input
                    case 0:
                        try
                        {
                            conn.Open();
                            sqlQuery = "UPDATE Employee SET Employee_Name_Surname = @name, Date_of_Birth = @dob, Contact_Number = @contact, Username = @user, Password = @password, Role = @role WHERE Employee_ID = @id";
                            command = new SqlCommand(sqlQuery, conn);
                            command.Parameters.AddWithValue("@id", txtSurname.Text);
                            command.Parameters.AddWithValue("@name", txtName.Text);
                            command.Parameters.AddWithValue("@dob", txtDOB.Text);
                            command.Parameters.AddWithValue("@contact", txtContactNumber.Text);
                            command.Parameters.AddWithValue("@user", txtUsername.Text);
                            command.Parameters.AddWithValue("@password", txtPassword.Text);

                            if (cbAdmin.Checked == true)
                            {
                                employeeRole = "Administrator";
                            }
                            else
                            {
                                employeeRole = "Employee";
                            }
                            command.Parameters.AddWithValue("@role", employeeRole);
                            command.ExecuteNonQuery();
                            conn.Close();
                            EmptyInput();
                            employeeLabel.Visible = true;
                            employeeComboBox.Visible = true;

                            


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
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO Employee (Employee_Name_Surname, Date_of_Birth, Contact_Number, Username, Password, Role) VALUES (@NameSurname, @DOB, @Number, @Username, @Password, @Role)", conn);
                            cmd.Parameters.AddWithValue("@NameSurname", txtName.Text + " " + txtSurname.Text);
                            cmd.Parameters.AddWithValue("@DOB", txtDOB.Text);
                            cmd.Parameters.AddWithValue("@Number", txtContactNumber.Text);
                            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                            if (cbAdmin.Checked)
                            {
                                cmd.Parameters.AddWithValue("@Role", "Administrator");
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@Role", "Employee");
                            }
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

                    default:
                        break;
                }
                EmptyInput();
                gbInput.Visible = false;
                ShowAllData();
            }
            else if (ValidateDeleteInput())
            {
                // Delete Data
                switch (cmbCommand.SelectedIndex)
                {
                    case 1:
                        gbInput.Visible = true;
                        int employeeId = int.Parse(cmbDelete.Text);

                        try
                        {
                            conn.Open();
                            sqlQuery = "SELECT Employee_Name_Surname FROM Employee WHERE Employee_ID = @Employee_ID";
                            command = new SqlCommand(sqlQuery, conn);
                            command.Parameters.AddWithValue("@Employee_ID", employeeId);
                            reader = command.ExecuteReader();
                            DialogResult getResult = DialogResult.None;
                            if (reader.Read())
                            {
                                getResult = MessageBox.Show("Are you sure you want to delete: " + reader.GetValue(0).ToString(), "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            }
                            conn.Close();

                            if (getResult == DialogResult.Yes)
                            {
                                conn.Open();
                                SqlCommand cmd = new SqlCommand(@"DELETE FROM Employee WHERE Employee_ID = @Employee_ID", conn);
                                cmd.Parameters.AddWithValue("@Employee_ID", employeeId);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                EmptyInput(); 
                            }
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("Can't Delete user that is part of Rent(s)+\n\nSQL Error: (" + sqlEx.Message+")");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        ShowAllData();

                        break;
                }
            }
        }

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            string getName = employeeComboBox.Text;
            string name = getName.Substring(3);

            //Make relevant input controls relevant
            
            employeeLabel.Visible = true;
            employeeComboBox.Visible = true;
            lblName.Text = "Name & Surname:";
            txtName.Visible = true;
            lblSurname.Text = "Employee ID:";
            lblSurname.Visible = true;
            txtSurname.Enabled = false;
            txtSurname.Visible = true;
            lblDOB.Visible = true;
            txtDOB.Visible = true;
            lblContactNumber.Visible = true;
            txtContactNumber.Visible = true;
            lblUserName.Visible = true;
            txtUsername.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            cbAdmin.Visible = true;
            btnSubmit.Text = "Update";
            gbInput.Text = "Update Employee";
            gbInput.Visible = true;
            cmbDelete.Visible = false;

            try
            {
                conn.Open();
                sqlQuery = "SELECT * FROM Employee WHERE Employee_Name_Surname = @name";
                command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@name", name);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtSurname.Text = reader.GetValue(0).ToString();
                    txtName.Text = reader.GetValue(1).ToString();
                    txtDOB.Text = Convert.ToDateTime(reader.GetValue(2)).ToString("yyyy-MM-dd");
                    txtContactNumber.Text = reader.GetValue(3).ToString();
                    txtUsername.Text = reader.GetValue(4).ToString();
                    txtPassword.Text = reader.GetValue(5).ToString();
                    if (reader.GetValue(6).ToString() == "Administrator")
                    {
                        cbAdmin.Checked = true;
                    }
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

        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAdmin.Checked == true)
            {
                employeeRole = "Administrator";
            } else
            {
                employeeRole = "Employee";
            }
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
            private bool ValidateUserInput()
        {
            bool allValid = true;

            foreach (TextBox textBox in new[] {txtName, txtSurname, txtDOB, txtContactNumber, txtUsername, txtPassword})
            {
                if (String.IsNullOrEmpty(textBox.Text)) {
                    allValid = false;
                    inputError.SetError(textBox, "Input is required. Cannot be blank");
                } else
                {
                    inputError.SetError(textBox, "");
                }
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

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }

    }
}
