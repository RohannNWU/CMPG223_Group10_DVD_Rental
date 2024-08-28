namespace CMPG223_Group10_DVD_Rental
{
    partial class ReportForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.reportComboBox = new System.Windows.Forms.ComboBox();
            this.reportListView = new System.Windows.Forms.ListView();
            this.inputError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.headerLabel.Location = new System.Drawing.Point(312, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(140, 40);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Reports";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.searchButton.Location = new System.Drawing.Point(301, 125);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(178, 69);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search for Report";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // reportComboBox
            // 
            this.reportComboBox.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.reportComboBox.FormattingEnabled = true;
            this.reportComboBox.Items.AddRange(new object[] {
            "Late DVD Report",
            "DVD Inventory"});
            this.reportComboBox.Location = new System.Drawing.Point(218, 67);
            this.reportComboBox.Name = "reportComboBox";
            this.reportComboBox.Size = new System.Drawing.Size(323, 29);
            this.reportComboBox.TabIndex = 2;
            this.reportComboBox.SelectedIndexChanged += new System.EventHandler(this.reportComboBox_SelectedIndexChanged);
            // 
            // reportListView
            // 
            this.reportListView.BackColor = System.Drawing.Color.Silver;
            this.reportListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.reportListView.HideSelection = false;
            this.reportListView.Location = new System.Drawing.Point(12, 213);
            this.reportListView.Name = "reportListView";
            this.reportListView.Size = new System.Drawing.Size(776, 261);
            this.reportListView.TabIndex = 3;
            this.reportListView.UseCompatibleStateImageBehavior = false;
            // 
            // inputError
            // 
            this.inputError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.inputError.ContainerControl = this;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.reportListView);
            this.Controls.Add(this.reportComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.headerLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.ShowIcon = false;
            this.Text = "Report Form";
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox reportComboBox;
        private System.Windows.Forms.ListView reportListView;
        private System.Windows.Forms.ErrorProvider inputError;
    }
}