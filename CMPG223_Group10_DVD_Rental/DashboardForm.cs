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
    public partial class DashboardForm : Form
    {
        private string name;
        private string role;
        public DashboardForm()
        {
            InitializeComponent();
        }

        public DashboardForm(string name, string role)
        {
            InitializeComponent();
            this.name = name;
            this.role = role;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            empLabel.Text = "Employee Logged in: " + name + ", (" + role + ")";
        }
    }
}
