namespace CMPG223_Group10_DVD_Rental
{
    partial class Employee
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
            System.Windows.Forms.Label lblCommand;
            this.lblHeader = new System.Windows.Forms.Label();
            this.DGVEmployee = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            lblCommand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).BeginInit();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCommand
            // 
            lblCommand.AutoSize = true;
            lblCommand.Location = new System.Drawing.Point(279, 324);
            lblCommand.Name = "lblCommand";
            lblCommand.Size = new System.Drawing.Size(90, 13);
            lblCommand.TabIndex = 4;
            lblCommand.Text = "Select Command:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(257, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(317, 31);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Employee Management";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGVEmployee
            // 
            this.DGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployee.Location = new System.Drawing.Point(81, 70);
            this.DGVEmployee.Name = "DGVEmployee";
            this.DGVEmployee.Size = new System.Drawing.Size(649, 215);
            this.DGVEmployee.TabIndex = 1;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(81, 291);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(87, 28);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCommand
            // 
            this.cmbCommand.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Items.AddRange(new object[] {
            "Update",
            "Delete",
            "Add"});
            this.cmbCommand.Location = new System.Drawing.Point(375, 321);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(121, 21);
            this.cmbCommand.TabIndex = 3;
            this.cmbCommand.SelectedIndexChanged += new System.EventHandler(this.cmbCommand_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(23, 76);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(55, 13);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname: ";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(23, 106);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(69, 13);
            this.lblDOB.TabIndex = 7;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(25, 137);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(87, 13);
            this.lblContactNumber.TabIndex = 8;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(25, 169);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Username:";
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.cbAdmin);
            this.gbInput.Controls.Add(this.txtPassword);
            this.gbInput.Controls.Add(this.txtUsername);
            this.gbInput.Controls.Add(this.txtContactNumber);
            this.gbInput.Controls.Add(this.txtDOB);
            this.gbInput.Controls.Add(this.txtSurname);
            this.gbInput.Controls.Add(this.txtName);
            this.gbInput.Controls.Add(this.lblPassword);
            this.gbInput.Controls.Add(this.btnSubmit);
            this.gbInput.Controls.Add(this.lblName);
            this.gbInput.Controls.Add(this.lblContactNumber);
            this.gbInput.Controls.Add(this.lblUserName);
            this.gbInput.Controls.Add(this.lblSurname);
            this.gbInput.Controls.Add(this.lblDOB);
            this.gbInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbInput.Location = new System.Drawing.Point(224, 357);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(312, 290);
            this.gbInput.TabIndex = 10;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            this.gbInput.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(123, 248);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 25);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 199);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(98, 73);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 13;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(98, 103);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 20);
            this.txtDOB.TabIndex = 14;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(113, 134);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(100, 20);
            this.txtContactNumber.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(98, 166);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 196);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 17;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAdmin.Location = new System.Drawing.Point(28, 222);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(82, 17);
            this.cbAdmin.TabIndex = 18;
            this.cbAdmin.Text = "Admin:        ";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 661);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(lblCommand);
            this.Controls.Add(this.cmbCommand);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.DGVEmployee);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).EndInit();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView DGVEmployee;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cmbCommand;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbAdmin;
    }
}