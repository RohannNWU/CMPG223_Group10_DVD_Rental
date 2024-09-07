namespace CMPG223_Group10_DVD_Rental
{
    partial class DVD
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
            this.dvdGridView = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            this.cmbDrop = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSelectName = new System.Windows.Forms.Label();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.shelfLabel = new System.Windows.Forms.Label();
            this.inputError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dvdGridView)).BeginInit();
            this.gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).BeginInit();
            this.SuspendLayout();
            // 
            // dvdGridView
            // 
            this.dvdGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dvdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvdGridView.Location = new System.Drawing.Point(19, 74);
            this.dvdGridView.Name = "dvdGridView";
            this.dvdGridView.RowHeadersWidth = 51;
            this.dvdGridView.Size = new System.Drawing.Size(683, 150);
            this.dvdGridView.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblHeader.Location = new System.Drawing.Point(248, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(264, 33);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "DVD Management";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbCommand
            // 
            this.cmbCommand.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Items.AddRange(new object[] {
            "Add DVD",
            "Delete DVD",
            "Update DVD",
            "Search Genre and Location"});
            this.cmbCommand.Location = new System.Drawing.Point(412, 233);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(223, 28);
            this.cmbCommand.TabIndex = 5;
            this.cmbCommand.SelectedIndexChanged += new System.EventHandler(this.cmbCommand_SelectedIndexChanged);
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblCommand.Location = new System.Drawing.Point(238, 236);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(137, 20);
            this.lblCommand.TabIndex = 6;
            this.lblCommand.Text = "Select command:";
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.cmbDelete);
            this.gbInput.Controls.Add(this.cmbDrop);
            this.gbInput.Controls.Add(this.btnSubmit);
            this.gbInput.Controls.Add(this.txtCopies);
            this.gbInput.Controls.Add(this.txtYear);
            this.gbInput.Controls.Add(this.txtName);
            this.gbInput.Controls.Add(this.lblCopies);
            this.gbInput.Controls.Add(this.lblYear);
            this.gbInput.Controls.Add(this.lblGenre);
            this.gbInput.Controls.Add(this.lblName);
            this.gbInput.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.gbInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.gbInput.Location = new System.Drawing.Point(19, 305);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(396, 224);
            this.gbInput.TabIndex = 7;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            this.gbInput.Visible = false;
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(209, 37);
            this.cmbDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(60, 28);
            this.cmbDelete.TabIndex = 10;
            this.cmbDelete.Visible = false;
            // 
            // cmbDrop
            // 
            this.cmbDrop.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cmbDrop.FormattingEnabled = true;
            this.cmbDrop.Items.AddRange(new object[] {
            "Action",
            "Animation",
            "Comedy",
            "Drama",
            "Fantasy",
            "Horror",
            "Romance",
            "Science Fiction"});
            this.cmbDrop.Location = new System.Drawing.Point(209, 101);
            this.cmbDrop.Name = "cmbDrop";
            this.cmbDrop.Size = new System.Drawing.Size(152, 28);
            this.cmbDrop.TabIndex = 9;
            this.cmbDrop.SelectedIndexChanged += new System.EventHandler(this.cmbDrop_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.btnSubmit.Location = new System.Drawing.Point(157, 178);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 40);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCopies
            // 
            this.txtCopies.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtCopies.Location = new System.Drawing.Point(209, 134);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(152, 25);
            this.txtCopies.TabIndex = 7;
            this.txtCopies.TextChanged += new System.EventHandler(this.txtCopies_TextChanged);
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtYear.Location = new System.Drawing.Point(209, 68);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(152, 25);
            this.txtYear.TabIndex = 5;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtName.Location = new System.Drawing.Point(209, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 25);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(26, 136);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(64, 20);
            this.lblCopies.TabIndex = 3;
            this.lblCopies.Text = "Copies:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(26, 71);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(45, 20);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(26, 103);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(64, 20);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Genre: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblSelectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.lblSelectName.Location = new System.Drawing.Point(238, 269);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(141, 20);
            this.lblSelectName.TabIndex = 8;
            this.lblSelectName.Text = "Select DVD name:";
            this.lblSelectName.Visible = false;
            // 
            // cmbNames
            // 
            this.cmbNames.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(412, 263);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(223, 28);
            this.cmbNames.TabIndex = 9;
            this.cmbNames.Visible = false;
            this.cmbNames.SelectedIndexChanged += new System.EventHandler(this.cmbNames_SelectedIndexChanged);
            // 
            // shelfLabel
            // 
            this.shelfLabel.AutoSize = true;
            this.shelfLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.shelfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.shelfLabel.Location = new System.Drawing.Point(464, 408);
            this.shelfLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shelfLabel.Name = "shelfLabel";
            this.shelfLabel.Size = new System.Drawing.Size(115, 20);
            this.shelfLabel.TabIndex = 10;
            this.shelfLabel.Text = "Shelf Location:";
            this.shelfLabel.Visible = false;
            // 
            // inputError
            // 
            this.inputError.ContainerControl = this;
            // 
            // DVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(717, 540);
            this.Controls.Add(this.shelfLabel);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.lblSelectName);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.cmbCommand);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dvdGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DVD";
            this.Text = "DVD";
            ((System.ComponentModel.ISupportInitialize)(this.dvdGridView)).EndInit();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvdGridView;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cmbCommand;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSelectName;
        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.ComboBox cmbDrop;
        private System.Windows.Forms.Label shelfLabel;
        private System.Windows.Forms.ErrorProvider inputError;
        private System.Windows.Forms.ComboBox cmbDelete;
    }
}