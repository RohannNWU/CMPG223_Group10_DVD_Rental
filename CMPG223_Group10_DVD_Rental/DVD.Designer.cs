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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSelectName = new System.Windows.Forms.Label();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.cmbDrop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(683, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(248, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(250, 31);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "DVD Management";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbCommand
            // 
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Items.AddRange(new object[] {
            "Add DVD",
            "Delete DVD",
            "Edit DVD",
            "Search Genre and Location"});
            this.cmbCommand.Location = new System.Drawing.Point(361, 236);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(121, 21);
            this.cmbCommand.TabIndex = 5;
            this.cmbCommand.SelectedIndexChanged += new System.EventHandler(this.cmbCommand_SelectedIndexChanged);
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommand.Location = new System.Drawing.Point(238, 236);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(116, 17);
            this.lblCommand.TabIndex = 6;
            this.lblCommand.Text = "Select command:";
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.cmbDrop);
            this.gbInput.Controls.Add(this.btnSubmit);
            this.gbInput.Controls.Add(this.txtCopies);
            this.gbInput.Controls.Add(this.txtYear);
            this.gbInput.Controls.Add(this.txtName);
            this.gbInput.Controls.Add(this.lblCopies);
            this.gbInput.Controls.Add(this.lblYear);
            this.gbInput.Controls.Add(this.lblGenre);
            this.gbInput.Controls.Add(this.lblName);
            this.gbInput.Location = new System.Drawing.Point(220, 293);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(303, 216);
            this.gbInput.TabIndex = 7;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            this.gbInput.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(100, 178);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(90, 72);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(26, 140);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(42, 13);
            this.lblCopies.TabIndex = 3;
            this.lblCopies.Text = "Copies:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(35, 75);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(31, 105);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(42, 13);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Genre: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectName.Location = new System.Drawing.Point(238, 269);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(111, 13);
            this.lblSelectName.TabIndex = 8;
            this.lblSelectName.Text = "Select DVD name:";
            this.lblSelectName.Visible = false;
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Items.AddRange(new object[] {
            "Add DVD",
            "Delete DVD",
            "Edit DVD",
            "Search Genre"});
            this.cmbNames.Location = new System.Drawing.Point(361, 266);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(121, 21);
            this.cmbNames.TabIndex = 9;
            this.cmbNames.Visible = false;
            this.cmbNames.SelectedIndexChanged += new System.EventHandler(this.cmbNames_SelectedIndexChanged);
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(90, 140);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(100, 20);
            this.txtCopies.TabIndex = 7;
            // 
            // cmbDrop
            // 
            this.cmbDrop.FormattingEnabled = true;
            this.cmbDrop.Items.AddRange(new object[] {
            "Horror",
            "Comedy",
            "Drama",
            "Action",
            "Romance",
            "Science Fiction",
            "Fantasy",
            "Animation"});
            this.cmbDrop.Location = new System.Drawing.Point(90, 105);
            this.cmbDrop.Name = "cmbDrop";
            this.cmbDrop.Size = new System.Drawing.Size(100, 21);
            this.cmbDrop.TabIndex = 9;
            // 
            // DVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 531);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.lblSelectName);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.cmbCommand);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DVD";
            this.Text = "DVD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}