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
    public partial class ShelfForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DVDRentalShop.mdf;Integrated Security=True";
        private string sqlQuery;
        private SqlConnection conn;
        private SqlCommand command;
        public ShelfForm()
        {
            InitializeComponent();
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genreComboBox.Text == "Add New Genre...")
            {
                newGenreLabel.Visible = true;
                newGenreTextBox.Visible = true;
            } else
            {
                newGenreLabel.Visible = false;
                newGenreTextBox.Visible = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                string genre = "";
                sqlQuery = "INSERT INTO Shelf (List_of_Genres, DVD_Capacity) VALUES (@genre, @capacity)";
                command = new SqlCommand(sqlQuery, conn);
                switch(genreComboBox.Text)
                {
                    case "Add New Genre...":
                        genre = newGenreTextBox.Text;
                        break;
                    default:
                        genre = genreComboBox.Text;
                        break;

                }
                command.Parameters.AddWithValue("@genre", genre);
                command.Parameters.AddWithValue("@capacity", "42");
                command.ExecuteNonQuery();
                MessageBox.Show("New Shelf Added");
                conn.Close();
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
    }
}
