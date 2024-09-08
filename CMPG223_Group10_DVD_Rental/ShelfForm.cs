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
    public partial class ShelfForm : Form
    {
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
    }
}
