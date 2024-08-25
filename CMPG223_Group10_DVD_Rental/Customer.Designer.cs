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
            this.btnShowAll = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            this.gbCommand.SuspendLayout();
            this.gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.Location = new System.Drawing.Point(13, 94);
            this.DGVCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.RowHeadersWidth = 51;
            this.DGVCustomer.Size = new System.Drawing.Size(956, 234);
            this.DGVCustomer.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(294, 26);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(390, 39);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Customer Management";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(154, 360);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(116, 34);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(48, 31);
            this.rbAdd.Margin = new System.Windows.Forms.Padding(4);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(170, 29);
            this.rbAdd.TabIndex = 5;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add new record";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(48, 68);
            this.rbDelete.Margin = new System.Windows.Forms.Padding(4);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(149, 29);
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
            this.gbCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCommand.Location = new System.Drawing.Point(106, 429);
            this.gbCommand.Margin = new System.Windows.Forms.Padding(4);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Padding = new System.Windows.Forms.Padding(4);
            this.gbCommand.Size = new System.Drawing.Size(357, 153);
            this.gbCommand.TabIndex = 8;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Select Command";
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.Location = new System.Drawing.Point(48, 104);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(156, 29);
            this.updateRadioButton.TabIndex = 8;
            this.updateRadioButton.TabStop = true;
            this.updateRadioButton.Text = "Update record";
            this.updateRadioButton.UseVisualStyleBackColor = true;
            this.updateRadioButton.CheckedChanged += new System.EventHandler(this.updateRadioButton_CheckedChanged);
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.btnSubmit);
            this.gbInput.Controls.Add(this.txtEmail);
            this.gbInput.Controls.Add(this.lblEmail);
            this.gbInput.Controls.Add(this.txtDOB);
            this.gbInput.Controls.Add(this.txtSurname);
            this.gbInput.Controls.Add(this.txtName);
            this.gbInput.Controls.Add(this.lblDOB);
            this.gbInput.Controls.Add(this.lblSurname);
            this.gbInput.Controls.Add(this.lblName);
            this.gbInput.Location = new System.Drawing.Point(561, 413);
            this.gbInput.Margin = new System.Windows.Forms.Padding(4);
            this.gbInput.Name = "gbInput";
            this.gbInput.Padding = new System.Windows.Forms.Padding(4);
            this.gbInput.Size = new System.Drawing.Size(340, 218);
            this.gbInput.TabIndex = 9;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            this.gbInput.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(93, 167);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 28);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 131);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 134);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(157, 97);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(4);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(132, 22);
            this.txtDOB.TabIndex = 5;
            this.txtDOB.TextChanged += new System.EventHandler(this.txtDOB_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(157, 61);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(132, 22);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(157, 25);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(19, 100);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(81, 16);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of birth:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(19, 64);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 16);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 28);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // memberComboBox
            // 
            this.memberComboBox.FormattingEnabled = true;
            this.memberComboBox.Location = new System.Drawing.Point(641, 360);
            this.memberComboBox.Name = "memberComboBox";
            this.memberComboBox.Size = new System.Drawing.Size(260, 24);
            this.memberComboBox.TabIndex = 10;
            this.memberComboBox.Visible = false;
            this.memberComboBox.SelectedIndexChanged += new System.EventHandler(this.memberComboBox_SelectedIndexChanged);
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Location = new System.Drawing.Point(404, 363);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(166, 16);
            this.memberLabel.TabIndex = 11;
            this.memberLabel.Text = "Please select the Member:";
            this.memberLabel.Visible = false;
            // 
            // inputError
            // 
            this.inputError.ContainerControl = this;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.memberLabel);
            this.Controls.Add(this.memberComboBox);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.DGVCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnShowAll;
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
    }
}