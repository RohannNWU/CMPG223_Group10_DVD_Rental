using System;
using System.Collections;
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
    public partial class DVD : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DVDRentalShop.mdf;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        private string sqlQuery;
        public DVD()
        {
            InitializeComponent();
        }

        private void cmbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select index
            int selectedIndex = cmbCommand.SelectedIndex;

            switch (selectedIndex)
            {
                case 3:
                    cmbNames.Items.Clear();
                    lblSelectName.Visible = true;
                    cmbNames.Visible = true;

                    conn = new SqlConnection(connectionString);

                    try
                    {
                        // Open the connection
                        conn.Open();

                        // Create a SqlCommand object
                        SqlCommand command = new SqlCommand(@"SELECT Name FROM DVD", conn);

                        // Execute the command and read the data
                        SqlDataReader reader = command.ExecuteReader();

                        // Loop through the data and add to the ComboBox
                        while (reader.Read())
                        {
                            cmbNames.Items.Add(reader["Name"].ToString());
                        }

                        conn.Close();
                        // Close the reader
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    break;
                default:
                    break;

            }
        }
    }
}
