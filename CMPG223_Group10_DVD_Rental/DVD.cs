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
        private SqlDataAdapter dataAdapter;
        private string sqlQuery;
        private string expectedShelf;
        private bool update = false;
        public DVD()
        {
            InitializeComponent();
            ShowAll();
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
                case 1:
                    //Hide un-used input controls
                    gbInput.Visible = true;
                    lblName.Text = "Insert ID to delete: ";
                    lblGenre.Visible = false;
                    lblYear.Visible = false;
                    lblCopies.Visible = false;
                    txtCopies.Visible = false; 
                    txtYear.Visible = false;
                    cmbDrop.Visible = false;
                    break;
                case 2:
                    // update the dvd details
                    cmbNames.Visible = true;
                    lblSelectName.Visible = true;

                    conn = new SqlConnection(connectionString);
                    try
                    {
                        conn.Open();
                        sqlQuery = "SELECT DVD_Name FROM DVD";
                        command = new SqlCommand(sqlQuery, conn);
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            cmbNames.Items.Add(reader.GetString(0));
                        }
                        conn.Close();
                        update = true;
                    } catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Couldn't connect to the database. " + sqlEx.Message);
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Error. " + ex.Message);
                    }
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
               
                        command = new SqlCommand(@"SELECT DVD_Name FROM DVD", conn);       
                        reader = command.ExecuteReader();

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
            string selectedDVDName = cmbNames.SelectedItem.ToString();
            conn = new SqlConnection(connectionString);

            // if displays the location of the selected DVD, else allows the update of the DVD
            if (update == false)
            {
                int selectedIndex = cmbCommand.SelectedIndex;

                try
                {
                    conn.Open();
                    command = new SqlCommand(@"SELECT DVD_Genre, Shelf_ID FROM DVD WHERE DVD_Name = @DVDName", conn);
                    command.Parameters.AddWithValue("@DVDName", selectedDVDName);
                    reader = command.ExecuteReader();

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
            } else
            {
                gbInput.Visible = true;
                btnSubmit.Text = "Update";
                try
                {
                    conn.Open();
                    sqlQuery = "SELECT * FROM DVD WHERE DVD_Name = @name";
                    command = new SqlCommand(sqlQuery, conn);
                    command.Parameters.AddWithValue("@name", selectedDVDName);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        shelfLabel.Text = "Shelf Location: " + reader.GetValue(1).ToString();
                        txtName.Text = reader.GetValue(2).ToString();
                        txtYear.Text = reader.GetValue(3).ToString();
                        cmbDrop.SelectedText = reader.GetValue(4).ToString();
                        txtCopies.Text = reader.GetValue(5).ToString();
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
            lblGenre.Visible = true;
            txtCopies.Text = "";
            txtCopies.Visible = true;
            lblCopies.Visible = true;
            cmbDrop.Visible = true;
            gbInput.Visible = false;
        }

        private void ShowAll()
        {
            dvdGridView.DataSource = null;
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                sqlQuery = "SELECT * FROM DVD";
                dataAdapter = new SqlDataAdapter(sqlQuery, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dvdGridView.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbCommand.SelectedIndex;
            conn = new SqlConnection(connectionString);

            switch (selectedIndex)
            {
                case 0:
                    try
                    {
                        conn.Open();
                        sqlQuery = "INSERT INTO DVD (Shelf_ID, DVD_Name, DVD_Year, DVD_Genre, DVD_Copies) VALUES (@shelf, @name, @year, @genre, @copies)";
                        command = new SqlCommand(sqlQuery, conn);
                        command.Parameters.AddWithValue("@shelf", expectedShelf);
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@year", txtYear.Text);
                        command.Parameters.AddWithValue("@genre", cmbDrop.Text);
                        command.Parameters.AddWithValue("@copies", txtCopies.Text);
                        command.ExecuteNonQuery();
                        conn.Close();
                        ResetInput();
                        shelfLabel.Visible = false;
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
                    gbInput.Visible = true;
                    int DVDId = int.Parse(txtName.Text);
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM DVD WHERE DVD_ID = @DVD_ID", conn);
                        cmd.Parameters.AddWithValue("@DVD_ID", DVDId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        shelfLabel.Visible = false;
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
                case 2:
                    // update the dvd details when the update button is clicked
                    try
                    {
                        conn.Open();
                        sqlQuery = "UPDATE DVD SET ";
                        conn.Close();
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Couldn't connect to the database. " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error. " + ex.Message);
                    }
                    break;
                default:
                    break;

            }
            ShowAll();
        }

        private void cmbDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGenre = cmbDrop.Text;

            conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                sqlQuery = "SELECT * FROM Shelf";
                command = new SqlCommand(sqlQuery, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string[] genres = new string[0];
                    genres = reader.GetValue(1).ToString().Split(',');
                    for (int i = 0; i < genres.Length; i++)
                    {
                        if (selectedGenre == genres[i])
                        {
                            shelfLabel.Text = "Expected Shelf Location: " + reader.GetValue(0).ToString();
                            expectedShelf = reader.GetValue(0).ToString();
                        }
                    }
                }
                reader.Close();
                conn.Close();
                shelfLabel.Visible = true;
            }
            catch (SqlException sqlEx) {
                MessageBox.Show("Couldn't connect to database. " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }
    }
}
