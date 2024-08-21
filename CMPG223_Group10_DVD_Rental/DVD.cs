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
using System.Xml.Linq;

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

        //Change input according to command selection
        private void cmbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int selectedIndex = cmbCommand.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:

                    gbInput.Visible = true;
                    break;

                case 3:

                    //Code for Search command 
                    cmbNames.Items.Clear();
                    lblSelectName.Visible = true;
                    cmbNames.Visible = true;

                    conn = new SqlConnection(connectionString);

                    try
                    {                     
                        conn.Open();
               
                        SqlCommand command = new SqlCommand(@"SELECT DVD_Name FROM DVD", conn);       
                        SqlDataReader reader = command.ExecuteReader();


                        while (reader.Read())
                        {
                            cmbNames.Items.Add(reader["DVD_Name"].ToString());
                        }

                        conn.Close();
                        
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

        //Show selected DVD's Genre + Location
        private void cmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int selectedIndex = cmbCommand.SelectedIndex;

            string selectedDVDName = cmbNames.SelectedItem.ToString();

            conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                
                SqlCommand command = new SqlCommand(@"SELECT DVD_Genre, Shelf_ID FROM DVD WHERE DVD_Name = @DVDName", conn);
                command.Parameters.AddWithValue("@DVDName", selectedDVDName);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    string genre = reader["DVD_Genre"].ToString();
                    string shelfID = reader["Shelf_ID"].ToString();

                    // Show the Genre and Shelf_ID in a MessageBox
                    MessageBox.Show($"Genre: {genre}\nShelf ID: {shelfID}", "DVD Details");
                }

                conn.Close();

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        //Method reset input controls
        private void ResetInput()
        {
            lblName.Text = "Name:";
            txtName.Text = "";
            txtName.Visible = true;
            lblName.Visible = true;
            txtYear.Text = "";
            txtYear.Visible = true;
            lblYear.Visible = true;
            txtGenre.Text = "";
            txtGenre.Visible = true;
            lblGenre.Visible = true;
            txtCopies.Text = "";
            txtCopies.Visible = true;
            lblCopies.Visible = true;

            gbInput.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbCommand.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    conn = new SqlConnection(connectionString);
                    try
                    {
                        conn.Open();

                        conn.Close();

                        ResetInput();
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
                case 1:
                    break;

                case 2:

                    break;
                default:
                    break;

            }
        }
    }
    }
}
