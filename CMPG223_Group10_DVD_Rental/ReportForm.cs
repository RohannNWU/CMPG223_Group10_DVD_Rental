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
        private System.Windows.Forms.SortOrder sortOrder = System.Windows.Forms.SortOrder.None;
        private int sortColumn = -1;
        private List<ListViewItem> allItems = new List<ListViewItem>();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(reportComboBox.Text))
            {
                string selectedReport = reportComboBox.Text;
                filterGroupBox.Visible = true;
                sortNameButton.Visible = true;
                switch (selectedReport)
                {
                    case "Late DVD Report":
                        sqlQuery = "SELECT Client_ID, DVD_ID, Start_Date, Return_Date FROM Rental WHERE Return_Date < @today";
                        sortNameButton.Visible = true;
                        GetLateReport(sqlQuery);
                        break;
                    case "DVD Inventory Report":
                        sqlQuery = "SELECT DVD_ID, DVD_Name, DVD_Copies FROM DVD";
                        sortNameButton.Visible = true;
                        GetInventoryList(sqlQuery);
                        break;
                    default:
                        break;
                }

                if (!String.IsNullOrEmpty(reportComboBox.Text))
                {
                    switch (reportComboBox.Text)
                    {
                        case "DVD Inventory Report":
                            sortDateButton.Visible = false;
                            reportDate.Text = reportComboBox.Text + " as per date: " + DateTime.Today.ToShortDateString();
                            reportDate.Visible = true;
                            filterGroupBox.Visible = false;
                            break;
                        case "Late DVD Report":
                            sortDateButton.Visible = true;
                            reportDate.Text = reportComboBox.Text + " as per date: " + DateTime.Today.ToShortDateString();
                            reportDate.Visible = true;
                            filterGroupBox.Visible = true;
                            break;
                    }
                }
                else
                {
                    reportDate.Visible = false;
                }
            } else
            {
                inputError.SetError(reportComboBox, "Please select an item. Cannot be blank.");
            }
        }

        private void GetLateReport(string sqlQuery)
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
                command = new SqlCommand(sqlQuery, conn);
                command.Parameters.AddWithValue("@today", (DateTime.Today.ToShortDateString()));
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    clientID.Add((int)reader.GetValue(0));
                    dvdID.Add((int)reader.GetValue(1));
                    returnDates.Add(Convert.ToDateTime(reader.GetValue(2)).ToString("yyyy/MM/dd"));
                }
                reader.Close();
                conn.Close();

                conn.Open();
                foreach (int id in clientID)
                {
                    sqlQuery = "SELECT Client_Name_Surname FROM CLIENT WHERE Client_ID = @client";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@client", id);
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                clientNames.Add(rdr.GetValue(0).ToString());
                            }
                        }
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
                    allItems.Add(item);
                }
                
            } catch (SqlException sqlEx)
            {
                MessageBox.Show("Sql Error. " + sqlEx.Message);
            } catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }

        private void GetInventoryList(string sqlQuery)
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
                command = new SqlCommand(sqlQuery, conn);
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    dvdID.Add((int)reader.GetValue(0));
                    dvdName.Add(reader.GetValue(1).ToString());
                    dvdCopies.Add((int)(reader.GetValue(2)));
                }
                reader.Close();
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
            filterGroupBox.Visible = false;
            sortNameButton.Visible = false;
            sortDateButton.Visible = false;
            reportDate.Visible = false;
        }

        private void customDay_CheckedChanged(object sender, EventArgs e)
        {
            if (customDay.Checked)
            {
                startLabel.Visible = true;
                startDatePicker.Visible = true;
                endDateLabel.Visible = true;
                endDatePicker.Visible = true;
            } else
            {
                startLabel.Visible = false;
                startDatePicker.Visible = false;
                endDateLabel.Visible = false;
                endDatePicker.Visible = false;
            }
        }

        private void sortNameButton_Click(object sender, EventArgs e)
        {
            int columnToSort = 1;
            if (sortColumn == columnToSort && sortOrder == System.Windows.Forms.SortOrder.Ascending)
            {
                sortOrder = System.Windows.Forms.SortOrder.Descending;
            }
            else
            {
                sortOrder = System.Windows.Forms.SortOrder.Ascending;
            }
            sortColumn = columnToSort;

            reportListView.ListViewItemSorter = new ListViewItemComparer(sortColumn, sortOrder);
            reportListView.Sort();
        }

        private void sortDateButton_Click(object sender, EventArgs e)
        {
            int columnToSort = 3;
            if (sortColumn == columnToSort && sortOrder == System.Windows.Forms.SortOrder.Ascending)
            {
                sortOrder = System.Windows.Forms.SortOrder.Descending;
            }
            else
            {
                sortOrder = System.Windows.Forms.SortOrder.Ascending;
            }
            sortColumn = columnToSort;

            reportListView.ListViewItemSorter = new ListViewItemComparer(sortColumn, sortOrder);
            reportListView.Sort();
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            DateTime fromDate;
            DateTime toDate = DateTime.Today;

            if (thirtyDay.Checked)
            {
                fromDate = DateTime.Today.AddDays(-30);
            }
            else if (sixtyDay.Checked)
            {
                fromDate = DateTime.Today.AddDays(-60);
            }
            else if (ninetyDay.Checked)
            {
                fromDate = DateTime.Today.AddDays(-90);
            }
            else if (customDay.Checked)
            {
                fromDate = startDatePicker.Value.Date;
                toDate = endDatePicker.Value.Date;
            }
            else
            {
                MessageBox.Show("Please select a filter option.");
                return;
            }

            FilterListViewItems(fromDate, toDate);
        }

        private void FilterListViewItems(DateTime fromDate, DateTime toDate)
        {
            reportListView.Items.Clear();
            foreach (var item in allItems)
            {
                DateTime itemDate = DateTime.Parse(item.SubItems[3].Text);
                if (itemDate >= fromDate && itemDate <= toDate)
                {
                    reportListView.Items.Add(item);
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
