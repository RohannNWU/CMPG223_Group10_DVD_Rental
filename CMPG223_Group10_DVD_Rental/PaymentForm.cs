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
    public partial class PaymentForm : Form
    {
        private string clientName;
        private decimal fine;
        public PaymentForm()
        {
            InitializeComponent();
        }

        public PaymentForm(string clientName, decimal fine)
        {
            InitializeComponent();
            this.clientName = clientName;
            this.fine = fine;
            clientLabel.Text = "Client Name: " + clientName;
            dueLabel.Text = "Amount Due: " + fine.ToString("C");
            amountTextBox.Text = fine.ToString();
        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in new[] {amountTextBox}) {
                if (String.IsNullOrEmpty(textBox.Text))
                {
                    inputError.SetError(textBox, "Input is required. Cannot be blank.");
                }
            }
        }

        public bool isPaid()
        {
            if (fine > 0.0M)
            {
                return false;
            } else
            {
                return true;
            }
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please follow the POS device instructions for payment.");
            fine = 0.0M;
            this.Close();
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            inputError.Clear();
        }
    }
}
