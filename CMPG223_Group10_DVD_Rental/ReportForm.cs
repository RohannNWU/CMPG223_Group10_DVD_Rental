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
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            conn = new SqlConnection(connectionString);

            try
            {

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
