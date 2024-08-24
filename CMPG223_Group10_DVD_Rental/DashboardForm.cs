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
    public partial class DashboardForm : Form
    {
        private string name;
        private string role;
        private int employeeID;
        private const decimal LATE_FEE = 3.0M;
        public DashboardForm()
        {
            InitializeComponent();
        }

        public DashboardForm(string name, string role, int employeeID)
        {
            InitializeComponent();
            this.name = name;
            this.role = role;
            this.employeeID = employeeID;
            DateTime today = DateTime.Now;
            todayLabel.Text = "Today's date: " + today.ToString("yyyy/MM/dd");
            DateTime returnDate = today.AddDays(14);
            returnLabel.Text = "Return date: " + returnDate.ToString("yyyy/MM/dd");
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            empLabel.Text = "Employee ID: " + employeeID +  ", Employee Logged in: " + name + ", (" + role + ")";
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TO-DO: Make the fields visible

            //TO-DO: Check if the member has outstanding DVDs in Rental Table, display outstanding groupbox
            
            // calculate the fine
            //SqlDataReader reader;
            //DateTime returnDate = reader.GetValue(5);
            //DateTime today = DateTime.Now;
            //int finedDays = today.Day - returnDate.Day;
            //decimal fine = LATE_FEE * finedDays;
            //fineLabel.Text = "Fine Due: " + fine.ToString("C");

            //"SELECT DVD_Name, DVD_Copies FROM DVD";

            //if (reader.GetValue(1) == 0)
            //{
            //    dvdComboBox.Items.Add(reader.GetValue(0).ToString() + " - Out of Stock");
            //}
        }
    }
}
