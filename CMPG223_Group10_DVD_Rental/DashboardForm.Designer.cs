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
            this.dvdLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.returnLabel = new System.Windows.Forms.Label();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.outstandingDVD = new System.Windows.Forms.GroupBox();
            this.payButton = new System.Windows.Forms.Button();
            this.fineLabel = new System.Windows.Forms.Label();
            this.outstandingDVDsListBox = new System.Windows.Forms.ListBox();
            this.outstandingDVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // empLabel
            // 
            this.empLabel.AutoSize = true;
            this.empLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
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
            this.memberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.memberLabel.Location = new System.Drawing.Point(534, 24);
            this.memberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(76, 20);
            this.memberLabel.TabIndex = 1;
            this.memberLabel.Text = "Member:";
            // 
            // dvdLabel
            // 
            this.dvdLabel.AutoSize = true;
            this.dvdLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.dvdLabel.Location = new System.Drawing.Point(19, 76);
            this.dvdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dvdLabel.Name = "dvdLabel";
            this.dvdLabel.Size = new System.Drawing.Size(94, 20);
            this.dvdLabel.TabIndex = 2;
            this.dvdLabel.Text = "DVD Name:";
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.todayLabel.Location = new System.Drawing.Point(19, 129);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(105, 20);
            this.todayLabel.TabIndex = 3;
            this.todayLabel.Text = "Today\'s Date:";
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.returnLabel.Location = new System.Drawing.Point(399, 129);
            this.returnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(100, 20);
            this.returnLabel.TabIndex = 4;
            this.returnLabel.Text = "Return Date:";
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.checkoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.Location = new System.Drawing.Point(547, 175);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(126, 46);
            this.checkoutButton.TabIndex = 5;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = false;
            // 
            // outstandingDVD
            // 
            this.outstandingDVD.Controls.Add(this.payButton);
            this.outstandingDVD.Controls.Add(this.fineLabel);
            this.outstandingDVD.Controls.Add(this.outstandingDVDsListBox);
            this.outstandingDVD.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outstandingDVD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.outstandingDVD.Location = new System.Drawing.Point(153, 234);
            this.outstandingDVD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outstandingDVD.Name = "outstandingDVD";
            this.outstandingDVD.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outstandingDVD.Size = new System.Drawing.Size(675, 284);
            this.outstandingDVD.TabIndex = 6;
            this.outstandingDVD.TabStop = false;
            this.outstandingDVD.Text = "Outstanding DVDs";
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.payButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.payButton.Location = new System.Drawing.Point(496, 193);
            this.payButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(126, 46);
            this.payButton.TabIndex = 7;
            this.payButton.Text = "Pay Now";
            this.payButton.UseVisualStyleBackColor = false;
            // 
            // fineLabel
            // 
            this.fineLabel.AutoSize = true;
            this.fineLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.fineLabel.Location = new System.Drawing.Point(493, 24);
            this.fineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fineLabel.Name = "fineLabel";
            this.fineLabel.Size = new System.Drawing.Size(89, 20);
            this.fineLabel.TabIndex = 7;
            this.fineLabel.Text = "Fine Due: R";
            // 
            // outstandingDVDsListBox
            // 
            this.outstandingDVDsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.outstandingDVDsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outstandingDVDsListBox.FormattingEnabled = true;
            this.outstandingDVDsListBox.ItemHeight = 20;
            this.outstandingDVDsListBox.Location = new System.Drawing.Point(14, 31);
            this.outstandingDVDsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outstandingDVDsListBox.Name = "outstandingDVDsListBox";
            this.outstandingDVDsListBox.Size = new System.Drawing.Size(420, 220);
            this.outstandingDVDsListBox.TabIndex = 0;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(975, 528);
            this.Controls.Add(this.outstandingDVD);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.dvdLabel);
            this.Controls.Add(this.memberLabel);
            this.Controls.Add(this.empLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.outstandingDVD.ResumeLayout(false);
            this.outstandingDVD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empLabel;
        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.Label dvdLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.GroupBox outstandingDVD;
        private System.Windows.Forms.ListBox outstandingDVDsListBox;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label fineLabel;
    }
}