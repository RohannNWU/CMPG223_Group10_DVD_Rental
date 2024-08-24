namespace CMPG223_Group10_DVD_Rental
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.empLabel = new System.Windows.Forms.Label();
            this.memberLabel = new System.Windows.Forms.Label();
            this.lblDVD = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.gbOutstandingDVD = new System.Windows.Forms.GroupBox();
            this.payButton = new System.Windows.Forms.Button();
            this.lblFine = new System.Windows.Forms.Label();
            this.outstandingDVDsListBox = new System.Windows.Forms.ListBox();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.cmbDVD = new System.Windows.Forms.ComboBox();
            this.gbOutstandingDVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // empLabel
            // 
            this.empLabel.AutoSize = true;
            this.empLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.empLabel.Location = new System.Drawing.Point(19, 24);
            this.empLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.empLabel.Name = "empLabel";
            this.empLabel.Size = new System.Drawing.Size(164, 20);
            this.empLabel.TabIndex = 0;
            this.empLabel.Text = "Employee Logged In:";
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.memberLabel.Location = new System.Drawing.Point(534, 24);
            this.memberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(76, 20);
            this.memberLabel.TabIndex = 1;
            this.memberLabel.Text = "Member:";
            // 
            // lblDVD
            // 
            this.lblDVD.AutoSize = true;
            this.lblDVD.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblDVD.Location = new System.Drawing.Point(19, 76);
            this.lblDVD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDVD.Name = "lblDVD";
            this.lblDVD.Size = new System.Drawing.Size(94, 20);
            this.lblDVD.TabIndex = 2;
            this.lblDVD.Text = "DVD Name:";
            this.lblDVD.Visible = false;
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblToday.Location = new System.Drawing.Point(19, 129);
            this.lblToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(105, 20);
            this.lblToday.TabIndex = 3;
            this.lblToday.Text = "Today\'s Date:";
            this.lblToday.Visible = false;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblReturnDate.Location = new System.Drawing.Point(399, 129);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(100, 20);
            this.lblReturnDate.TabIndex = 4;
            this.lblReturnDate.Text = "Return Date:";
            this.lblReturnDate.Visible = false;
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.checkoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.Location = new System.Drawing.Point(23, 188);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(126, 46);
            this.checkoutButton.TabIndex = 5;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Visible = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // gbOutstandingDVD
            // 
            this.gbOutstandingDVD.Controls.Add(this.payButton);
            this.gbOutstandingDVD.Controls.Add(this.lblFine);
            this.gbOutstandingDVD.Controls.Add(this.outstandingDVDsListBox);
            this.gbOutstandingDVD.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOutstandingDVD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.gbOutstandingDVD.Location = new System.Drawing.Point(153, 234);
            this.gbOutstandingDVD.Margin = new System.Windows.Forms.Padding(2);
            this.gbOutstandingDVD.Name = "gbOutstandingDVD";
            this.gbOutstandingDVD.Padding = new System.Windows.Forms.Padding(2);
            this.gbOutstandingDVD.Size = new System.Drawing.Size(675, 259);
            this.gbOutstandingDVD.TabIndex = 6;
            this.gbOutstandingDVD.TabStop = false;
            this.gbOutstandingDVD.Text = "Outstanding DVDs";
            this.gbOutstandingDVD.Visible = false;
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.payButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.payButton.Location = new System.Drawing.Point(472, 165);
            this.payButton.Margin = new System.Windows.Forms.Padding(2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(126, 46);
            this.payButton.TabIndex = 7;
            this.payButton.Text = "Pay Now";
            this.payButton.UseVisualStyleBackColor = false;
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblFine.Location = new System.Drawing.Point(477, 31);
            this.lblFine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(89, 20);
            this.lblFine.TabIndex = 7;
            this.lblFine.Text = "Fine Due: R";
            // 
            // outstandingDVDsListBox
            // 
            this.outstandingDVDsListBox.BackColor = System.Drawing.Color.Silver;
            this.outstandingDVDsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outstandingDVDsListBox.FormattingEnabled = true;
            this.outstandingDVDsListBox.ItemHeight = 20;
            this.outstandingDVDsListBox.Location = new System.Drawing.Point(14, 31);
            this.outstandingDVDsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.outstandingDVDsListBox.Name = "outstandingDVDsListBox";
            this.outstandingDVDsListBox.Size = new System.Drawing.Size(420, 180);
            this.outstandingDVDsListBox.TabIndex = 0;
            // 
            // cmbMember
            // 
            this.cmbMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(625, 23);
            this.cmbMember.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(160, 21);
            this.cmbMember.TabIndex = 7;
            this.cmbMember.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbDVD
            // 
            this.cmbDVD.FormattingEnabled = true;
            this.cmbDVD.Location = new System.Drawing.Point(122, 77);
            this.cmbDVD.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDVD.Name = "cmbDVD";
            this.cmbDVD.Size = new System.Drawing.Size(176, 21);
            this.cmbDVD.TabIndex = 8;
            this.cmbDVD.Visible = false;
            this.cmbDVD.SelectedIndexChanged += new System.EventHandler(this.cmbDVD_SelectedIndexChanged);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(975, 543);
            this.Controls.Add(this.cmbDVD);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.gbOutstandingDVD);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblDVD);
            this.Controls.Add(this.memberLabel);
            this.Controls.Add(this.empLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.gbOutstandingDVD.ResumeLayout(false);
            this.gbOutstandingDVD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empLabel;
        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.Label lblDVD;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.GroupBox gbOutstandingDVD;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.ComboBox cmbDVD;
        private System.Windows.Forms.ListBox outstandingDVDsListBox;
    }
}