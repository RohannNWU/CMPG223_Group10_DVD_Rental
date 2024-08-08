/*
 *
 * CMPG223 Project - G10 DVD Rentals
 * Date Created: 03/08/2024
 * Rohann Venter, 25130757
 * Jacques van Heerden, 35317906 
 * Francois Verster, 40723380
 * Stefan Venter, 39066894
 * Christo Prinsloo, 21052239
 *
 */

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
            conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                sqlQuery = @"SELECT * From dbo.Employee WHERE Username = @username AND Password = @password"; // preventing SQL injection by using parameters
                command = new SqlCommand(sqlQuery, conn);
                if (!String.IsNullOrEmpty(usernameTextBox.Text) || !String.IsNullOrEmpty(passwordTextBox.Text))
                {
                    command.Parameters.AddWithValue("@username", usernameTextBox.Text);
                    command.Parameters.AddWithValue("@password", passwordTextBox.Text);
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string role = reader["Role"].ToString();

                        if (role == "Administrator")
                        {
                            AdminMainMenu dashboard = new AdminMainMenu();
                            dashboard.Show();
                            this.Hide();
                            dashboard.FormClosed += (s, args) => this.Close(); // closes the login form that is hidden when the main program is closed
                        } else
                        {
                            EmployeeMainMenu dashboard = new EmployeeMainMenu();
                            dashboard.Show();
                            this.Hide();
                            dashboard.FormClosed += (s, args) => this.Close(); // closes the login form that is hidden when the main program is closed
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Error: Username and Password don't match.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("Population Error: Fields cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            } catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message); // displays the SQL error
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // displays any normal error encountered
            }
        }
    }
}
