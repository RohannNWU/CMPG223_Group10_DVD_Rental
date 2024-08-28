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
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            if (!String.IsNullOrEmpty(reportComboBox.Text))
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
            } else
            {
                inputError.SetError(reportComboBox, "Please select an item. Cannot be blank.");
            }
        }

        private void GetLateReport()
        {
            reportListView.Items.Clear();
            reportListView.Columns.Clear();
            reportListView.View = View.Details;
            reportListView.Columns.Add("Client ID", 100, HorizontalAlignment.Left);
            reportListView.Columns.Add("Client Name", 300, HorizontalAlignment.Left);
            reportListView.Columns.Add("DVD ID", 100, HorizontalAlignment.Left);
            reportListView.Columns.Add("Return Date", 100, HorizontalAlignment.Left);
            List<int> clientID = new List<int>();
            List<string> clientNames = new List<string>();
            List<int> dvdID = new List<int>();
            List<string> returnDates = new List<string>();
            conn = new SqlConnection(connectionString);

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
                for (int i = 0; i < clientID.Count; i++)
                {
                    ListViewItem item = new ListViewItem(clientID[i].ToString());
                    item.SubItems.Add(clientNames[i]);
                    item.SubItems.Add(dvdID[i].ToString());
                    item.SubItems.Add(returnDates[i].ToString());
                    reportListView.Items.Add(item);
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
            reportListView.Items.Clear();
            reportListView.Columns.Clear();
            reportListView.View = View.Details;
            reportListView.Columns.Add("DVD ID", 100, HorizontalAlignment.Left);
            reportListView.Columns.Add("DVD Name", 300, HorizontalAlignment.Left);
            reportListView.Columns.Add("Copies", 100, HorizontalAlignment.Left);
            List<int> dvdID = new List<int>();
            List<string> dvdName = new List<string>();
            List<int> dvdCopies = new List<int>();

            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                sqlQuery = "SELECT DVD_ID, DVD_Name, DVD_Copies FROM DVD";
                command = new SqlCommand(sqlQuery, conn);
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    dvdID.Add((int)reader.GetValue(0));
                    dvdName.Add(reader.GetValue(1).ToString());
                    dvdCopies.Add((int)(reader.GetValue(2)));
                }
                conn.Close();

                for (int i = 0; i < dvdID.Count; i++)
                {
                    ListViewItem item = new ListViewItem(dvdID[i].ToString());
                    item.SubItems.Add(dvdName[i]);
                    item.SubItems.Add(dvdCopies[i].ToString());
                    reportListView.Items.Add(item);
                }
            } catch (SqlException sqlEx)
            {
                MessageBox.Show("Sql Error. " + sqlEx.Message);
            } catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }

        private void reportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputError.Clear();
            reportListView.Items.Clear();
            reportListView.Columns.Clear();
        }
    }
}
