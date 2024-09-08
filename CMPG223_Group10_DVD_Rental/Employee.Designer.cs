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
            this.components = new System.ComponentModel.Container();
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
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.inputError = new System.Windows.Forms.ErrorProvider(this.components);
            lblCommand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).BeginInit();
            this.gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCommand
            // 
            lblCommand.AutoSize = true;
            lblCommand.Font = new System.Drawing.Font("Century Gothic", 11F);
            lblCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            lblCommand.Location = new System.Drawing.Point(23, 372);
            lblCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCommand.Name = "lblCommand";
            lblCommand.Size = new System.Drawing.Size(174, 22);
            lblCommand.TabIndex = 4;
            lblCommand.Text = "Select Command:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblHeader.Location = new System.Drawing.Point(288, 25);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(416, 40);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Employee Management";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DGVEmployee
            // 
            this.DGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployee.Location = new System.Drawing.Point(13, 85);
            this.DGVEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVEmployee.Name = "DGVEmployee";
            this.DGVEmployee.RowHeadersWidth = 51;
            this.DGVEmployee.Size = new System.Drawing.Size(956, 178);
            this.DGVEmployee.TabIndex = 1;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.btnShowAll.Location = new System.Drawing.Point(13, 283);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(116, 34);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCommand
            // 
            this.cmbCommand.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCommand.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Items.AddRange(new object[] {
            "Update Employee",
            "Delete Employee",
            "Add Employee"});
            this.cmbCommand.Location = new System.Drawing.Point(244, 369);
            this.cmbCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(201, 29);
            this.cmbCommand.TabIndex = 3;
            this.cmbCommand.SelectedIndexChanged += new System.EventHandler(this.cmbCommand_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 55);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 22);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(31, 94);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(101, 22);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname: ";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(31, 130);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(128, 22);
            this.lblDOB.TabIndex = 7;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(33, 169);
            this.lblContactNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(172, 22);
            this.lblContactNumber.TabIndex = 8;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(33, 208);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(106, 22);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Username:";
            // 
            // gbInput
            // 
            this.gbInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.gbInput.Controls.Add(this.cmbDelete);
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
            this.gbInput.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.gbInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.gbInput.Location = new System.Drawing.Point(481, 271);
            this.gbInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInput.Name = "gbInput";
            this.gbInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInput.Size = new System.Drawing.Size(487, 370);
            this.gbInput.TabIndex = 10;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            this.gbInput.Visible = false;
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(247, 52);
            this.cmbDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(76, 29);
            this.cmbDelete.TabIndex = 19;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAdmin.Location = new System.Drawing.Point(35, 281);
            this.cbAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(225, 26);
            this.cbAdmin.TabIndex = 18;
            this.cbAdmin.Text = "Admin Privileges:        ";
            this.cbAdmin.UseVisualStyleBackColor = true;
            this.cbAdmin.CheckedChanged += new System.EventHandler(this.cbAdmin_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPassword.Location = new System.Drawing.Point(247, 242);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(195, 30);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtUsername.Location = new System.Drawing.Point(247, 206);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(195, 30);
            this.txtUsername.TabIndex = 16;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtContactNumber.Location = new System.Drawing.Point(247, 166);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(195, 30);
            this.txtContactNumber.TabIndex = 15;
            this.txtContactNumber.TextChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtDOB.Location = new System.Drawing.Point(247, 127);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(195, 30);
            this.txtDOB.TabIndex = 14;
            this.txtDOB.TextChanged += new System.EventHandler(this.txtDOB_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSurname.Location = new System.Drawing.Point(247, 89);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(195, 30);
            this.txtSurname.TabIndex = 13;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtName.Location = new System.Drawing.Point(247, 52);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 30);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(33, 245);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 22);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.btnSubmit.Location = new System.Drawing.Point(247, 321);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 41);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.employeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.employeeLabel.Location = new System.Drawing.Point(24, 450);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(201, 22);
            this.employeeLabel.TabIndex = 11;
            this.employeeLabel.Text = "Select the Employee:";
            this.employeeLabel.Visible = false;
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(244, 448);
            this.employeeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(201, 29);
            this.employeeComboBox.TabIndex = 12;
            this.employeeComboBox.Visible = false;
            this.employeeComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeComboBox_SelectedIndexChanged);
            // 
            // inputError
            // 
            this.inputError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.inputError.ContainerControl = this;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(981, 654);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(lblCommand);
            this.Controls.Add(this.cmbCommand);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.DGVEmployee);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).EndInit();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView DGVEmployee;
        private System.Windows.Forms.Button btnShowAll;
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
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.ErrorProvider inputError;
        private System.Windows.Forms.ComboBox cmbCommand;
        private System.Windows.Forms.ComboBox cmbDelete;
    }
}