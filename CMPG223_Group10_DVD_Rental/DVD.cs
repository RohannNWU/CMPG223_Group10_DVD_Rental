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
using System.Linq;
using System.Windows.Forms;

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
        private int dvdID = 0;
        public DVD()
        {
            InitializeComponent();
            ShowAll();
        }

        //Change input according to command selection
        private void cmbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectName.Visible = false;
            cmbNames.Visible = false;
            string selectedIndex = cmbCommand.Text;
            gbInput.Visible = false;

            switch (selectedIndex)
            {
                case "Add DVD":
                    lblName.Text = "Name: ";
                    txtName.Clear();
                    lblGenre.Visible = true;
                    lblYear.Visible = true;
                    lblCopies.Visible = true;
                    txtCopies.Visible = true;
                    txtCopies.Clear();
                    txtYear.Visible = true;
                    txtYear.Clear();
                    cmbDrop.Visible = true;
                    cmbDrop.SelectedIndex = -1;
                    shelfLabel.Visible = false;
                    gbInput.Visible = true;
                    cmbNames.Visible = false;
                    lblSelectName.Visible = false;
                    btnSubmit.Text = "Add DVD";
                    break;
                case "Delete DVD":
                    //Hide un-used input controls
                    lblName.Text = "Select ID to delete: ";
                    txtName.Visible = false;
                    lblGenre.Visible = false;
                    lblYear.Visible = false;
                    lblCopies.Visible = false;
                    txtCopies.Visible = false; 
                    txtYear.Visible = false;
                    cmbDrop.Visible = false;
                    gbInput.Visible = true;
                    btnSubmit.Text = "Delete";
                    cmbDelete.Visible = true;
                    try
                    {
                        conn.Open();
                        command = new SqlCommand(@"SELECT DVD_ID FROM DVD", conn);
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
                case "Update DVD":
                    // update the dvd details
                    cmbNames.Visible = true;
                    lblSelectName.Visible = true;
                    lblName.Text = "Name: ";
                    lblGenre.Visible = true;
                    lblYear.Visible = true;
                    lblCopies.Visible = true;
                    txtCopies.Visible = true;
                    txtYear.Visible = true;
                    cmbDrop.Visible = true;
                    btnSubmit.Text = "Update";

                    conn = new SqlConnection(connectionString);
                    try
                    {
                        conn.Open();
                        sqlQuery = "SELECT DVD_ID, DVD_Name FROM DVD";
                        command = new SqlCommand(sqlQuery, conn);
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            cmbNames.Items.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString());
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
                case "Search Genre and Location":
                    //Code for Search command
                    gbInput.Visible = false;
                    shelfLabel.Visible = false;
                    cmbNames.Items.Clear();
                    lblSelectName.Visible = true;
                    cmbNames.Visible = true;
                    update = false;

                    conn = new SqlConnection(connectionString);
                    try
                    {                     
                        conn.Open();
                        command = new SqlCommand(@"SELECT DVD_ID, DVD_Name FROM DVD", conn);       
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            cmbNames.Items.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1));
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
            string[] getSelectedDVDName = cmbNames.Text.Split('-');
            string selectedDVDName = getSelectedDVDName[1];
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
                        string genre = reader.GetValue(0).ToString();
                        string shelfID = reader.GetValue(1).ToString();

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

                    if (reader.Read())
                    {
                        expectedShelf = reader.GetValue(1).ToString();
                        shelfLabel.Text = "Shelf Location: " + expectedShelf;
                        txtName.Text = reader.GetValue(2).ToString();
                        txtYear.Text = reader.GetValue(3).ToString();
                        txtCopies.Text = reader.GetValue(5).ToString();
                        string genre = reader.GetValue(4).ToString();
                        string[] items = cmbDrop.Items.Cast<String>().ToArray();
                        for (int i = 0; i < items.Length; i++) {
                            if (items[i].Equals(genre))
                            {
                                cmbDrop.SelectedIndex = i;
                            }
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
            cmbDelete.Visible = false;
            cmbDelete.Items.Clear();
        }

        private void ShowAll()
        {
            dvdGridView.DataSource = null;
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                dataAdapter = new SqlDataAdapter();
                DataSet dataSet = new DataSet();
                sqlQuery = "SELECT * FROM DVD";
                command = new SqlCommand(sqlQuery, conn);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSet, "DVD");
                dvdGridView.DataSource = dataSet;
                dvdGridView.DataMember = "DVD";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput() == true)
            {
                string selectedIndex = cmbCommand.Text;
                conn = new SqlConnection(connectionString);

                switch (selectedIndex)
                {
                    case "Add DVD":
                        if (DateTime.TryParseExact(txtYear.Text, "yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                        {
                            if (int.TryParse(txtCopies.Text, out int copies))
                            {
                                try
                                {
                                    conn.Open();
                                    sqlQuery = "INSERT INTO DVD (Shelf_ID, DVD_Name, DVD_Year, DVD_Genre, DVD_Copies) VALUES (@shelf, @name, @year, @genre, @copies)";
                                    command = new SqlCommand(sqlQuery, conn);
                                    command.Parameters.AddWithValue("@shelf", expectedShelf);
                                    command.Parameters.AddWithValue("@name", txtName.Text);
                                    command.Parameters.AddWithValue("@year", txtYear.Text);
                                    command.Parameters.AddWithValue("@genre", cmbDrop.Text);
                                    command.Parameters.AddWithValue("@copies", copies.ToString());
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
                            } else
                            {
                                inputError.SetError(txtCopies, "Please enter a value.");
                            }
                        } else
                        {
                            inputError.SetError(txtYear, "Year has to be in the format yyyy.");                           
                        }
                        break;
                    case "Update DVD":
                        string[] id = cmbNames.Text.Split('-');
                        dvdID = int.Parse(id[0]);
                        // update the dvd details when the update button is clicked
                        try
                        {
                            conn.Open();
                            sqlQuery = "UPDATE DVD SET Shelf_ID = @shelf, DVD_Name = @name, DVD_Year = @year, DVD_Genre = @genre, DVD_Copies = @copies WHERE DVD_ID = @id";
                            command = new SqlCommand(sqlQuery, conn);
                            command.Parameters.AddWithValue("@shelf", expectedShelf);
                            command.Parameters.AddWithValue("@name", txtName.Text);
                            command.Parameters.AddWithValue("@year", txtYear.Text);
                            command.Parameters.AddWithValue("@genre", cmbDrop.Text);
                            command.Parameters.AddWithValue("@copies", txtCopies.Text);
                            command.Parameters.AddWithValue("@id", dvdID);
                            command.ExecuteNonQuery();
                            conn.Close();
                            ResetInput();
                            cmbNames.Visible = false;
                            lblSelectName.Visible = false;
                            shelfLabel.Visible = false;
                            cmbNames.Items.Clear();
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
            else if (ValidateDeleteInput())
            {
                switch (cmbCommand.Text)
                {
                    case "Delete DVD":
                        shelfLabel.Visible = false;
                        dvdID = int.Parse(cmbDelete.Text);
                        try
                        {
                            conn.Open();
                            sqlQuery = "SELECT DVD_Name FROM DVD WHERE DVD_ID = @DVD_ID";
                            command = new SqlCommand(sqlQuery, conn);
                            command.Parameters.AddWithValue("@DVD_ID", dvdID);
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
                                sqlQuery = "DELETE FROM DVD WHERE DVD_ID = @DVD_ID";
                                command = new SqlCommand(sqlQuery, conn);
                                command.Parameters.AddWithValue("@DVD_ID", dvdID);
                                command.ExecuteNonQuery();
                                conn.Close();
                                ResetInput();
                            }   
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
                ShowAll();
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

        private void cmbDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputError.Clear();
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

        private bool ValidateUserInput()
        {
            bool allValid = true;
            foreach (TextBox textBox in new[] {txtName, txtYear, txtCopies})
            {
                if (textBox.Visible)
                {
                    if (String.IsNullOrEmpty(textBox.Text))
                    {
                        allValid = false;
                        inputError.SetError(textBox, "Input is needed. Cannot be blank.");
                    }

                    if (String.IsNullOrEmpty(cmbDrop.Text))
                    {
                        allValid = false;
                        inputError.SetError(cmbDrop, "Please choose an option. Cannot be blank.");
                    }
                    else
                    {
                        inputError.SetError(textBox, "");
                    }
                }
            }

            if (String.IsNullOrEmpty(cmbDrop.Text))
            {
                allValid = false;
                inputError.SetError(cmbDrop, "Please choose an option. Cannot be blank.");
            }
            return allValid;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }

        private void txtCopies_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }
    }
}
