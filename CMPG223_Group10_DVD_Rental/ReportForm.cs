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
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CMPG223_Group10_DVD_Rental
{
    public partial class ReportForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DVDRentalShop.mdf;Integrated Security=True";
        private string sqlQuery;
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        public ReportForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string selectedReport = reportComboBox.Text;
            switch (selectedReport)
            {
                case "Late DVD Report":
                    GetLateReport();
                    break;
                case "DVD Inventory":
                    GetInventoryList();
                    break;
                default:
                    break;
            }
        }

        private void GetLateReport()
        {
            reportListBox.Items.Clear();
            conn = new SqlConnection(connectionString);
            List<int> clientID = new List<int>();
            List<string> clientNames = new List<string>();
            List<int> dvdID = new List<int>();
            List<string> returnDates = new List<string>();

            try
            {
                conn.Open();
                sqlQuery = "SELECT Client_ID, DVD_ID, Return_Date FROM Rental WHERE Return_Date < @today";
                command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@today", DateTime.Today.ToShortDateString());
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    clientID.Add((int)reader.GetValue(0));
                    dvdID.Add((int)reader.GetValue(1));
                    returnDates.Add(Convert.ToDateTime(reader.GetValue(2)).ToString("yyyy/MM/dd"));
                }
                conn.Close();

                conn.Open();
                sqlQuery = "SELECT Client_Name_Surname FROM CLIENT WHERE Client_ID = @client";
                command = new SqlCommand(sqlQuery, conn);
                foreach (int id in clientID)
                {
                    command.Parameters.AddWithValue("@client", id);
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        clientNames.Add(reader.GetValue(0).ToString());
                    }
                }
                conn.Close();
                reportListBox.Items.Add($"{"Client ID",-12}{"Client Name",-15}\t{"DVD ID",-5}\t{"Return Date"}");
                for (int i = 0; i < clientID.Count; i++)
                {
                    string entry = $"{clientID[i],-14}\t{clientNames[i],-15}\t{dvdID[i],-5}\t{returnDates[i]:yyyy/MM/dd}";
                    reportListBox.Items.Add(entry);
                }
            } catch (SqlException sqlEx)
            {
                MessageBox.Show("Sql Error. " + sqlEx.Message);
            } catch (Exception ex)
            {
                MessageBox.Show("Exception. " + ex.Message);
            }
        }

        private void GetInventoryList()
        {

        }
    }
}
