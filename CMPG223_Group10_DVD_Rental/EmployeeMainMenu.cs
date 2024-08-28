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
    public partial class EmployeeMainMenu : Form
    {
        private string name;
        private string role;
        private int employeeID;
        public EmployeeMainMenu()
        {
            InitializeComponent();
            this.menuStrip.Renderer = new CustomRenderer();
        }
        public EmployeeMainMenu(string name, string role, int employeeID)
        {
            InitializeComponent();
            this.menuStrip.Renderer = new CustomRenderer();
            this.name = name;
            this.role = role;
            this.employeeID = employeeID;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmployeeMainMenu_Load(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm(name, role, employeeID);
            dashboard.MdiParent = this;
            dashboard.Show();
        }

        private void helpGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://wonderful-flower-0f477a010.5.azurestaticapps.net/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.\n" + ex.Message);
            }
        }

        // Open respective forms when clicked on Menu Strip
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customerForm = new Customer();
            customerForm.MdiParent = this;
            customerForm.Show();
        }

        private void dVDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DVD DVDForm = new DVD();
            DVDForm.MdiParent = this;
            DVDForm.Show();
        }
    }
}
