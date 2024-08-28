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
            this.headerLabel = new System.Windows.Forms.Label();
            this.rentingGroupBox = new System.Windows.Forms.GroupBox();
            this.returnGroupBox = new System.Windows.Forms.GroupBox();
            this.returnComboBox = new System.Windows.Forms.ComboBox();
            this.returnDVDLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.gbOutstandingDVD.SuspendLayout();
            this.rentingGroupBox.SuspendLayout();
            this.returnGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // empLabel
            // 
            this.empLabel.AutoSize = true;
            this.empLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.empLabel.Location = new System.Drawing.Point(37, 71);
            this.empLabel.Name = "empLabel";
            this.empLabel.Size = new System.Drawing.Size(204, 22);
            this.empLabel.TabIndex = 0;
            this.empLabel.Text = "Employee Logged In:";
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.memberLabel.Location = new System.Drawing.Point(724, 71);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(92, 22);
            this.memberLabel.TabIndex = 1;
            this.memberLabel.Text = "Member:";
            // 
            // lblDVD
            // 
            this.lblDVD.AutoSize = true;
            this.lblDVD.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblDVD.Location = new System.Drawing.Point(21, 51);
            this.lblDVD.Name = "lblDVD";
            this.lblDVD.Size = new System.Drawing.Size(119, 22);
            this.lblDVD.TabIndex = 2;
            this.lblDVD.Text = "DVD Name:";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblToday.Location = new System.Drawing.Point(21, 116);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(134, 22);
            this.lblToday.TabIndex = 3;
            this.lblToday.Text = "Today\'s Date:";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblReturnDate.Location = new System.Drawing.Point(21, 178);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(127, 22);
            this.lblReturnDate.TabIndex = 4;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.checkoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.checkoutButton.Location = new System.Drawing.Point(412, 143);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(168, 57);
            this.checkoutButton.TabIndex = 5;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // gbOutstandingDVD
            // 
            this.gbOutstandingDVD.Controls.Add(this.payButton);
            this.gbOutstandingDVD.Controls.Add(this.lblFine);
            this.gbOutstandingDVD.Controls.Add(this.outstandingDVDsListBox);
            this.gbOutstandingDVD.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOutstandingDVD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.gbOutstandingDVD.Location = new System.Drawing.Point(260, 365);
            this.gbOutstandingDVD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOutstandingDVD.Name = "gbOutstandingDVD";
            this.gbOutstandingDVD.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOutstandingDVD.Size = new System.Drawing.Size(900, 319);
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
            this.payButton.Location = new System.Drawing.Point(629, 203);
            this.payButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(168, 57);
            this.payButton.TabIndex = 7;
            this.payButton.Text = "Make Payment";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblFine.Location = new System.Drawing.Point(625, 71);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(111, 22);
            this.lblFine.TabIndex = 7;
            this.lblFine.Text = "Fine Due: R";
            // 
            // outstandingDVDsListBox
            // 
            this.outstandingDVDsListBox.BackColor = System.Drawing.Color.Silver;
            this.outstandingDVDsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outstandingDVDsListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.outstandingDVDsListBox.FormattingEnabled = true;
            this.outstandingDVDsListBox.ItemHeight = 21;
            this.outstandingDVDsListBox.Location = new System.Drawing.Point(19, 38);
            this.outstandingDVDsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outstandingDVDsListBox.Name = "outstandingDVDsListBox";
            this.outstandingDVDsListBox.Size = new System.Drawing.Size(560, 252);
            this.outstandingDVDsListBox.TabIndex = 0;
            // 
            // cmbMember
            // 
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(845, 69);
            this.cmbMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(257, 24);
            this.cmbMember.TabIndex = 7;
            this.cmbMember.SelectedIndexChanged += new System.EventHandler(this.cmbMember_SelectedIndexChanged);
            this.cmbMember.TextUpdate += new System.EventHandler(this.cmbMember_TextUpdate);
            // 
            // cmbDVD
            // 
            this.cmbDVD.FormattingEnabled = true;
            this.cmbDVD.Location = new System.Drawing.Point(159, 52);
            this.cmbDVD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDVD.Name = "cmbDVD";
            this.cmbDVD.Size = new System.Drawing.Size(405, 29);
            this.cmbDVD.TabIndex = 8;
            this.cmbDVD.SelectedIndexChanged += new System.EventHandler(this.cmbDVD_SelectedIndexChanged);
            this.cmbDVD.TextUpdate += new System.EventHandler(this.cmbDVD_TextUpdate);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.headerLabel.Location = new System.Drawing.Point(608, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(204, 40);
            this.headerLabel.TabIndex = 9;
            this.headerLabel.Text = "DVD Rental";
            // 
            // rentingGroupBox
            // 
            this.rentingGroupBox.Controls.Add(this.cmbDVD);
            this.rentingGroupBox.Controls.Add(this.lblDVD);
            this.rentingGroupBox.Controls.Add(this.lblToday);
            this.rentingGroupBox.Controls.Add(this.lblReturnDate);
            this.rentingGroupBox.Controls.Add(this.checkoutButton);
            this.rentingGroupBox.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentingGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.rentingGroupBox.Location = new System.Drawing.Point(41, 111);
            this.rentingGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentingGroupBox.Name = "rentingGroupBox";
            this.rentingGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentingGroupBox.Size = new System.Drawing.Size(628, 240);
            this.rentingGroupBox.TabIndex = 8;
            this.rentingGroupBox.TabStop = false;
            this.rentingGroupBox.Text = "Renting DVDs";
            this.rentingGroupBox.Visible = false;
            // 
            // returnGroupBox
            // 
            this.returnGroupBox.Controls.Add(this.returnComboBox);
            this.returnGroupBox.Controls.Add(this.returnDVDLabel);
            this.returnGroupBox.Controls.Add(this.returnButton);
            this.returnGroupBox.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.returnGroupBox.Location = new System.Drawing.Point(749, 111);
            this.returnGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnGroupBox.Name = "returnGroupBox";
            this.returnGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnGroupBox.Size = new System.Drawing.Size(628, 240);
            this.returnGroupBox.TabIndex = 9;
            this.returnGroupBox.TabStop = false;
            this.returnGroupBox.Text = "Return DVDs";
            this.returnGroupBox.Visible = false;
            // 
            // returnComboBox
            // 
            this.returnComboBox.FormattingEnabled = true;
            this.returnComboBox.Location = new System.Drawing.Point(159, 52);
            this.returnComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnComboBox.Name = "returnComboBox";
            this.returnComboBox.Size = new System.Drawing.Size(288, 29);
            this.returnComboBox.TabIndex = 8;
            // 
            // returnDVDLabel
            // 
            this.returnDVDLabel.AutoSize = true;
            this.returnDVDLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDVDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.returnDVDLabel.Location = new System.Drawing.Point(21, 51);
            this.returnDVDLabel.Name = "returnDVDLabel";
            this.returnDVDLabel.Size = new System.Drawing.Size(119, 22);
            this.returnDVDLabel.TabIndex = 2;
            this.returnDVDLabel.Text = "DVD Name:";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.returnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.returnButton.Location = new System.Drawing.Point(418, 143);
            this.returnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(168, 57);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "Return DVDs";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1420, 760);
            this.Controls.Add(this.returnGroupBox);
            this.Controls.Add(this.rentingGroupBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.cmbMember);
            this.Controls.Add(this.gbOutstandingDVD);
            this.Controls.Add(this.memberLabel);
            this.Controls.Add(this.empLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.gbOutstandingDVD.ResumeLayout(false);
            this.gbOutstandingDVD.PerformLayout();
            this.rentingGroupBox.ResumeLayout(false);
            this.rentingGroupBox.PerformLayout();
            this.returnGroupBox.ResumeLayout(false);
            this.returnGroupBox.PerformLayout();
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
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox rentingGroupBox;
        private System.Windows.Forms.GroupBox returnGroupBox;
        private System.Windows.Forms.ComboBox returnComboBox;
        private System.Windows.Forms.Label returnDVDLabel;
        private System.Windows.Forms.Button returnButton;
    }
}