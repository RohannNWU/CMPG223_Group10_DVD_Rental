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
using System.Windows.Forms;

namespace CMPG223_Group10_DVD_Rental
{
    public partial class AdminMainMenu : Form
    {
        private string name;
        private string role;
        private int employeeID;

        public AdminMainMenu()
        {
            InitializeComponent();
            this.menuStrip.Renderer = new CustomRenderer();
        }

        public AdminMainMenu(string name, string role, int employeeID)
        {
            InitializeComponent();
            this.name = name;
            this.role = role;
            this.employeeID = employeeID;
            this.menuStrip.Renderer = new CustomRenderer();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminMainMenu_Load(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm(name, role, employeeID);
            dashboard.MdiParent = this;
            dashboard.Show();
        }

        private void helpGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://sacmpg223g10.z1.web.core.windows.net/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked." + ex.Message);
            }
        }

        // Open respective forms when clicked on Menu Strip
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employeeForm = new Employee();
            employeeForm.MdiParent = this;
            employeeForm.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customerForm = new Customer();
            customerForm.MdiParent = this;
            customerForm.Show();
        }

        private void dvdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DVD DVDForm = new DVD();
            DVDForm.MdiParent = this;
            DVDForm.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.MdiParent = this;
            report.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://sacmpg223g10.z1.web.core.windows.net/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked." + ex.Message);
            }
        }
    }
}
