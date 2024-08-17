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

        //Change input according to command selection
        private void cmbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int selectedIndex = cmbCommand.SelectedIndex;

            switch (selectedIndex)
            {


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
    }
}
