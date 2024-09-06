namespace CMPG223_Group10_DVD_Rental
{
    partial class Customer
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
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.updateRadioButton = new System.Windows.Forms.RadioButton();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.memberComboBox = new System.Windows.Forms.ComboBox();
            this.memberLabel = new System.Windows.Forms.Label();
            this.inputError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ascendButton = new System.Windows.Forms.Button();
            this.descendButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            this.gbCommand.SuspendLayout();
            this.gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.Location = new System.Drawing.Point(10, 76);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.RowHeadersWidth = 51;
            this.DGVCustomer.Size = new System.Drawing.Size(717, 190);
            this.DGVCustomer.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblHeader.Location = new System.Drawing.Point(220, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(333, 33);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Customer Management";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(36, 25);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(149, 24);
            this.rbAdd.TabIndex = 5;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add new record";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(36, 55);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(130, 24);
            this.rbDelete.TabIndex = 6;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "Delete record";
            this.rbDelete.UseVisualStyleBackColor = true;
            this.rbDelete.CheckedChanged += new System.EventHandler(this.rbDelete_CheckedChanged);
            // 
            // gbCommand
            // 
            this.gbCommand.Controls.Add(this.updateRadioButton);
            this.gbCommand.Controls.Add(this.rbAdd);
            this.gbCommand.Controls.Add(this.rbDelete);
            this.gbCommand.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.gbCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.gbCommand.Location = new System.Drawing.Point(10, 375);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(268, 124);
            this.gbCommand.TabIndex = 8;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Select Command";
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.Location = new System.Drawing.Point(36, 84);
            this.updateRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(137, 24);
            this.updateRadioButton.TabIndex = 8;
            this.updateRadioButton.TabStop = true;
            this.updateRadioButton.Text = "Update record";
            this.updateRadioButton.UseVisualStyleBackColor = true;
            this.updateRadioButton.CheckedChanged += new System.EventHandler(this.updateRadioButton_CheckedChanged);
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.cmbDelete);
            this.gbInput.Controls.Add(this.btnSubmit);
            this.gbInput.Controls.Add(this.txtEmail);
            this.gbInput.Controls.Add(this.lblEmail);
            this.gbInput.Controls.Add(this.txtDOB);
            this.gbInput.Controls.Add(this.txtSurname);
            this.gbInput.Controls.Add(this.txtName);
            this.gbInput.Controls.Add(this.lblDOB);
            this.gbInput.Controls.Add(this.lblSurname);
            this.gbInput.Controls.Add(this.lblName);
            this.gbInput.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.gbInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.gbInput.Location = new System.Drawing.Point(421, 336);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(293, 177);
            this.gbInput.TabIndex = 9;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            this.gbInput.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.btnSubmit.Location = new System.Drawing.Point(90, 137);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 35);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtEmail.Location = new System.Drawing.Point(128, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 25);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 109);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtDOB.Location = new System.Drawing.Point(128, 79);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(146, 25);
            this.txtDOB.TabIndex = 5;
            this.txtDOB.TextChanged += new System.EventHandler(this.txtDOB_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSurname.Location = new System.Drawing.Point(128, 50);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(146, 25);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtName.Location = new System.Drawing.Point(128, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 25);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(14, 81);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(104, 20);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of birth:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(14, 52);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(76, 20);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // memberComboBox
            // 
            this.memberComboBox.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.memberComboBox.FormattingEnabled = true;
            this.memberComboBox.Location = new System.Drawing.Point(532, 284);
            this.memberComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memberComboBox.Name = "memberComboBox";
            this.memberComboBox.Size = new System.Drawing.Size(196, 28);
            this.memberComboBox.TabIndex = 10;
            this.memberComboBox.Visible = false;
            this.memberComboBox.SelectedIndexChanged += new System.EventHandler(this.memberComboBox_SelectedIndexChanged);
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.memberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.memberLabel.Location = new System.Drawing.Point(322, 284);
            this.memberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(204, 20);
            this.memberLabel.TabIndex = 11;
            this.memberLabel.Text = "Please select the Member:";
            this.memberLabel.Visible = false;
            // 
            // inputError
            // 
            this.inputError.ContainerControl = this;
            // 
            // ascendButton
            // 
            this.ascendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.ascendButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.ascendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ascendButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.ascendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.ascendButton.Location = new System.Drawing.Point(18, 278);
            this.ascendButton.Name = "ascendButton";
            this.ascendButton.Size = new System.Drawing.Size(100, 30);
            this.ascendButton.TabIndex = 12;
            this.ascendButton.Text = "Sort Name";
            this.ascendButton.UseVisualStyleBackColor = false;
            this.ascendButton.Click += new System.EventHandler(this.ascendButton_Click);
            // 
            // descendButton
            // 
            this.descendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.descendButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.descendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descendButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.descendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.descendButton.Location = new System.Drawing.Point(134, 278);
            this.descendButton.Name = "descendButton";
            this.descendButton.Size = new System.Drawing.Size(100, 30);
            this.descendButton.TabIndex = 13;
            this.descendButton.Text = "Sort ID";
            this.descendButton.UseVisualStyleBackColor = false;
            this.descendButton.Click += new System.EventHandler(this.descendButton_Click);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.filterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.filterLabel.Location = new System.Drawing.Point(9, 323);
            this.filterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(100, 20);
            this.filterLabel.TabIndex = 14;
            this.filterLabel.Text = "Filter Names:";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.filterTextBox.Location = new System.Drawing.Point(119, 320);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(168, 25);
            this.filterTextBox.TabIndex = 11;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(139, 17);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(88, 28);
            this.cmbDelete.TabIndex = 11;
            this.cmbDelete.Visible = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(738, 522);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.descendButton);
            this.Controls.Add(this.ascendButton);
            this.Controls.Add(this.memberLabel);
            this.Controls.Add(this.memberComboBox);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.DGVCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            this.gbCommand.ResumeLayout(false);
            this.gbCommand.PerformLayout();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCustomer;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbCommand;
        public System.Windows.Forms.RadioButton rbAdd;
        public System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton updateRadioButton;
        private System.Windows.Forms.ComboBox memberComboBox;
        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.ErrorProvider inputError;
        private System.Windows.Forms.Button descendButton;
        private System.Windows.Forms.Button ascendButton;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox cmbDelete;
    }
}