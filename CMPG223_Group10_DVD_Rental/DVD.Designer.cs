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
            this.dvdGridView = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.gbInput = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dvdGridView)).BeginInit();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvdGridView
            // 
            this.dvdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvdGridView.Location = new System.Drawing.Point(25, 91);
            this.dvdGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dvdGridView.Name = "dvdGridView";
            this.dvdGridView.RowHeadersWidth = 51;
            this.dvdGridView.Size = new System.Drawing.Size(911, 185);
            this.dvdGridView.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(331, 25);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(311, 39);
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
            "Update DVD",
            "Search Genre and Location"});
            this.cmbCommand.Location = new System.Drawing.Point(481, 290);
            this.cmbCommand.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(160, 24);
            this.cmbCommand.TabIndex = 5;
            this.cmbCommand.SelectedIndexChanged += new System.EventHandler(this.cmbCommand_SelectedIndexChanged);
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommand.Location = new System.Drawing.Point(317, 290);
            this.lblCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(139, 20);
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
            this.gbInput.Location = new System.Drawing.Point(75, 375);
            this.gbInput.Margin = new System.Windows.Forms.Padding(4);
            this.gbInput.Name = "gbInput";
            this.gbInput.Padding = new System.Windows.Forms.Padding(4);
            this.gbInput.Size = new System.Drawing.Size(404, 266);
            this.gbInput.TabIndex = 7;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            this.gbInput.Visible = false;
            // 
            // cmbDrop
            // 
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
            this.cmbDrop.Location = new System.Drawing.Point(120, 129);
            this.cmbDrop.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDrop.Name = "cmbDrop";
            this.cmbDrop.Size = new System.Drawing.Size(132, 24);
            this.cmbDrop.TabIndex = 9;
            this.cmbDrop.SelectedIndexChanged += new System.EventHandler(this.cmbDrop_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(133, 219);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(120, 172);
            this.txtCopies.Margin = new System.Windows.Forms.Padding(4);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(132, 22);
            this.txtCopies.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(120, 89);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(132, 22);
            this.txtYear.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 48);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 4;
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(35, 172);
            this.lblCopies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(53, 16);
            this.lblCopies.TabIndex = 3;
            this.lblCopies.Text = "Copies:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(47, 92);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 16);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(41, 129);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(50, 16);
            this.lblGenre.TabIndex = 1;
            this.lblGenre.Text = "Genre: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 48);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectName.Location = new System.Drawing.Point(317, 331);
            this.lblSelectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(139, 17);
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
            this.cmbNames.Location = new System.Drawing.Point(481, 327);
            this.cmbNames.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(160, 24);
            this.cmbNames.TabIndex = 9;
            this.cmbNames.Visible = false;
            this.cmbNames.SelectedIndexChanged += new System.EventHandler(this.cmbNames_SelectedIndexChanged);
            // 
            // shelfLabel
            // 
            this.shelfLabel.AutoSize = true;
            this.shelfLabel.Location = new System.Drawing.Point(507, 507);
            this.shelfLabel.Name = "shelfLabel";
            this.shelfLabel.Size = new System.Drawing.Size(154, 16);
            this.shelfLabel.TabIndex = 10;
            this.shelfLabel.Text = "Expected Shelf Location:";
            this.shelfLabel.Visible = false;
            // 
            // DVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 654);
            this.Controls.Add(this.shelfLabel);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.lblSelectName);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.cmbCommand);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dvdGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DVD";
            this.Text = "DVD";
            ((System.ComponentModel.ISupportInitialize)(this.dvdGridView)).EndInit();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
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
    }
}