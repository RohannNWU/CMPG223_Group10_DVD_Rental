namespace CMPG223_Group10_DVD_Rental
{
    partial class ShelfForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.genreLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.newGenreLabel = new System.Windows.Forms.Label();
            this.newGenreTextBox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.btnSubmit.Location = new System.Drawing.Point(284, 271);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 49);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.genreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.genreLabel.Location = new System.Drawing.Point(13, 84);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(134, 22);
            this.genreLabel.TabIndex = 10;
            this.genreLabel.Text = "Select Genre:";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.capacityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.capacityLabel.Location = new System.Drawing.Point(13, 205);
            this.capacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(201, 22);
            this.capacityLabel.TabIndex = 11;
            this.capacityLabel.Text = "Default Capacity: 42";
            // 
            // genreComboBox
            // 
            this.genreComboBox.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Add New Genre...",
            "Action,Animation",
            "Comedy,Drama",
            "Fantasy,Horror",
            "Romance,Science Fiction"});
            this.genreComboBox.Location = new System.Drawing.Point(238, 81);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(185, 29);
            this.genreComboBox.TabIndex = 12;
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genreComboBox_SelectedIndexChanged);
            // 
            // newGenreLabel
            // 
            this.newGenreLabel.AutoSize = true;
            this.newGenreLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.newGenreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.newGenreLabel.Location = new System.Drawing.Point(13, 142);
            this.newGenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newGenreLabel.Name = "newGenreLabel";
            this.newGenreLabel.Size = new System.Drawing.Size(171, 22);
            this.newGenreLabel.TabIndex = 13;
            this.newGenreLabel.Text = "Enter new Genre:";
            this.newGenreLabel.Visible = false;
            // 
            // newGenreTextBox
            // 
            this.newGenreTextBox.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.newGenreTextBox.Location = new System.Drawing.Point(238, 142);
            this.newGenreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newGenreTextBox.Name = "newGenreTextBox";
            this.newGenreTextBox.Size = new System.Drawing.Size(185, 30);
            this.newGenreTextBox.TabIndex = 14;
            this.newGenreTextBox.Visible = false;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.headerLabel.Location = new System.Drawing.Point(60, 9);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(331, 40);
            this.headerLabel.TabIndex = 15;
            this.headerLabel.Text = "Shelf Management";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.exitButton.Location = new System.Drawing.Point(17, 271);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 49);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // ShelfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(436, 348);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.newGenreTextBox);
            this.Controls.Add(this.newGenreLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShelfForm";
            this.ShowIcon = false;
            this.Text = "Maintaining Shelves";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label newGenreLabel;
        private System.Windows.Forms.TextBox newGenreTextBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button exitButton;
    }
}