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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Group10_DVD_Rental
{
    public partial class AdminMainMenu : Form
    {
        private string name;
        private string role;

        public AdminMainMenu()
        {
            InitializeComponent();
            this.menuStrip.Renderer = new CustomRenderer();
        }

        public AdminMainMenu(string name, string role)
        {
            InitializeComponent();
            this.name = name;
            this.role = role;
            this.menuStrip.Renderer = new CustomRenderer();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminMainMenu_Load(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm(name, role);
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
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        // Open Employee form when clicked on MenuStrip
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employeeForm = new Employee();
            employeeForm.Show();
        }
    }
}
