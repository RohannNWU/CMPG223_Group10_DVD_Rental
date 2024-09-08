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
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPG223_Group10_DVD_Rental
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DVDRentalShop.mdf;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        private string sqlQuery;
        public Login()
        {
            InitializeComponent();
        }

        // login button validates the user and gets their role in the organization
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                conn = new SqlConnection(connectionString);

                try
                {
                    conn.Open();
                    sqlQuery = @"SELECT Employee_ID, Employee_Name_Surname, Role From Employee WHERE Username = @username AND Password = @password"; // preventing SQL injection by using parameters
                    command = new SqlCommand(sqlQuery, conn);
                    command.Parameters.AddWithValue("@username", usernameTextBox.Text);
                    command.Parameters.AddWithValue("@password", passwordTextBox.Text);
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string role = reader.GetValue(2).ToString();
                        if (role == "Administrator")
                        {
                            AdminMainMenu dashboard = new AdminMainMenu(reader.GetValue(1).ToString(), role, (int)reader.GetValue(0));
                            dashboard.Show();
                            this.Hide();
                            dashboard.FormClosed += (s, args) => this.Close(); // closes the login form that is hidden when the main program is closed
                        }
                        else
                        {
                            EmployeeMainMenu dashboard = new EmployeeMainMenu(reader.GetValue(1).ToString(), role, (int)reader.GetValue(0));
                            dashboard.Show();
                            this.Hide();
                            dashboard.FormClosed += (s, args) => this.Close(); // closes the login form that is hidden when the main program is closed
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Error: Username and Password don't match.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message); // displays the SQL error
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); // displays any normal error encountered
                }
            }
        }

        private bool ValidateUserInput()
        {
            bool allValid = true;
            foreach (MaskedTextBox textBox in new[] {usernameTextBox, passwordTextBox})
            {
                if (String.IsNullOrEmpty(textBox.Text))
                {
                    allValid = false;
                    inputError.SetError(textBox, "Input is required. Cannot be blank.");
                } else
                {
                    inputError.SetError(textBox, "");
                }
            }
            return allValid;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usernameTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
