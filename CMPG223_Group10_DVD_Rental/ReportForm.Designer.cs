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
            this.reportDate = new System.Windows.Forms.Label();
            this.sortNameButton = new System.Windows.Forms.Button();
            this.sortDateButton = new System.Windows.Forms.Button();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.customButton = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.customDay = new System.Windows.Forms.RadioButton();
            this.ninetyDay = new System.Windows.Forms.RadioButton();
            this.sixtyDay = new System.Windows.Forms.RadioButton();
            this.thirtyDay = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).BeginInit();
            this.filterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.headerLabel.Location = new System.Drawing.Point(531, 13);
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
            this.searchButton.Location = new System.Drawing.Point(613, 65);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(221, 44);
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
            "DVD Inventory Report"});
            this.reportComboBox.Location = new System.Drawing.Point(257, 74);
            this.reportComboBox.Name = "reportComboBox";
            this.reportComboBox.Size = new System.Drawing.Size(323, 29);
            this.reportComboBox.TabIndex = 2;
            this.reportComboBox.SelectedIndexChanged += new System.EventHandler(this.reportComboBox_SelectedIndexChanged);
            // 
            // reportListView
            // 
            this.reportListView.BackColor = System.Drawing.Color.Silver;
            this.reportListView.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.reportListView.HideSelection = false;
            this.reportListView.Location = new System.Drawing.Point(12, 169);
            this.reportListView.Name = "reportListView";
            this.reportListView.Size = new System.Drawing.Size(1115, 261);
            this.reportListView.TabIndex = 3;
            this.reportListView.UseCompatibleStateImageBehavior = false;
            // 
            // inputError
            // 
            this.inputError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.inputError.ContainerControl = this;
            // 
            // reportDate
            // 
            this.reportDate.AutoSize = true;
            this.reportDate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.reportDate.Location = new System.Drawing.Point(290, 129);
            this.reportDate.Name = "reportDate";
            this.reportDate.Size = new System.Drawing.Size(0, 27);
            this.reportDate.TabIndex = 6;
            this.reportDate.Visible = false;
            // 
            // sortNameButton
            // 
            this.sortNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.sortNameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.sortNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortNameButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.sortNameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.sortNameButton.Location = new System.Drawing.Point(24, 469);
            this.sortNameButton.Name = "sortNameButton";
            this.sortNameButton.Size = new System.Drawing.Size(178, 69);
            this.sortNameButton.TabIndex = 7;
            this.sortNameButton.Text = "Sort by Name";
            this.sortNameButton.UseVisualStyleBackColor = false;
            this.sortNameButton.Visible = false;
            this.sortNameButton.Click += new System.EventHandler(this.sortNameButton_Click);
            // 
            // sortDateButton
            // 
            this.sortDateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.sortDateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.sortDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortDateButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.sortDateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.sortDateButton.Location = new System.Drawing.Point(24, 555);
            this.sortDateButton.Name = "sortDateButton";
            this.sortDateButton.Size = new System.Drawing.Size(178, 69);
            this.sortDateButton.TabIndex = 8;
            this.sortDateButton.Text = "Sort by Return Date";
            this.sortDateButton.UseVisualStyleBackColor = false;
            this.sortDateButton.Visible = false;
            this.sortDateButton.Click += new System.EventHandler(this.sortDateButton_Click);
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.customButton);
            this.filterGroupBox.Controls.Add(this.endDatePicker);
            this.filterGroupBox.Controls.Add(this.startDatePicker);
            this.filterGroupBox.Controls.Add(this.endDateLabel);
            this.filterGroupBox.Controls.Add(this.startLabel);
            this.filterGroupBox.Controls.Add(this.customDay);
            this.filterGroupBox.Controls.Add(this.ninetyDay);
            this.filterGroupBox.Controls.Add(this.sixtyDay);
            this.filterGroupBox.Controls.Add(this.thirtyDay);
            this.filterGroupBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.filterGroupBox.Location = new System.Drawing.Point(232, 447);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(850, 229);
            this.filterGroupBox.TabIndex = 9;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filter";
            this.filterGroupBox.Visible = false;
            // 
            // customButton
            // 
            this.customButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.customButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.customButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.customButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.customButton.Location = new System.Drawing.Point(381, 159);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(153, 44);
            this.customButton.TabIndex = 10;
            this.customButton.Text = "Search";
            this.customButton.UseVisualStyleBackColor = false;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(381, 86);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(440, 36);
            this.endDatePicker.TabIndex = 13;
            this.endDatePicker.Visible = false;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(381, 37);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(440, 36);
            this.startDatePicker.TabIndex = 12;
            this.startDatePicker.Visible = false;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.endDateLabel.Location = new System.Drawing.Point(206, 91);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(106, 27);
            this.endDateLabel.TabIndex = 11;
            this.endDateLabel.Text = "To Date:";
            this.endDateLabel.Visible = false;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.startLabel.Location = new System.Drawing.Point(206, 42);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(135, 27);
            this.startLabel.TabIndex = 10;
            this.startLabel.Text = "From Date:";
            this.startLabel.Visible = false;
            // 
            // customDay
            // 
            this.customDay.AutoSize = true;
            this.customDay.Location = new System.Drawing.Point(27, 183);
            this.customDay.Name = "customDay";
            this.customDay.Size = new System.Drawing.Size(182, 31);
            this.customDay.TabIndex = 3;
            this.customDay.TabStop = true;
            this.customDay.Text = "Custom Date";
            this.customDay.UseVisualStyleBackColor = true;
            this.customDay.CheckedChanged += new System.EventHandler(this.customDay_CheckedChanged);
            // 
            // ninetyDay
            // 
            this.ninetyDay.AutoSize = true;
            this.ninetyDay.Location = new System.Drawing.Point(27, 135);
            this.ninetyDay.Name = "ninetyDay";
            this.ninetyDay.Size = new System.Drawing.Size(120, 31);
            this.ninetyDay.TabIndex = 2;
            this.ninetyDay.TabStop = true;
            this.ninetyDay.Text = "90 Days";
            this.ninetyDay.UseVisualStyleBackColor = true;
            // 
            // sixtyDay
            // 
            this.sixtyDay.AutoSize = true;
            this.sixtyDay.Location = new System.Drawing.Point(27, 86);
            this.sixtyDay.Name = "sixtyDay";
            this.sixtyDay.Size = new System.Drawing.Size(120, 31);
            this.sixtyDay.TabIndex = 1;
            this.sixtyDay.TabStop = true;
            this.sixtyDay.Text = "60 Days";
            this.sixtyDay.UseVisualStyleBackColor = true;
            // 
            // thirtyDay
            // 
            this.thirtyDay.AutoSize = true;
            this.thirtyDay.Location = new System.Drawing.Point(27, 38);
            this.thirtyDay.Name = "thirtyDay";
            this.thirtyDay.Size = new System.Drawing.Size(120, 31);
            this.thirtyDay.TabIndex = 0;
            this.thirtyDay.TabStop = true;
            this.thirtyDay.Text = "30 Days";
            this.thirtyDay.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1139, 688);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.sortDateButton);
            this.Controls.Add(this.sortNameButton);
            this.Controls.Add(this.reportDate);
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
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox reportComboBox;
        private System.Windows.Forms.ListView reportListView;
        private System.Windows.Forms.ErrorProvider inputError;
        private System.Windows.Forms.Label reportDate;
        private System.Windows.Forms.Button sortDateButton;
        private System.Windows.Forms.Button sortNameButton;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.RadioButton customDay;
        private System.Windows.Forms.RadioButton ninetyDay;
        private System.Windows.Forms.RadioButton sixtyDay;
        private System.Windows.Forms.RadioButton thirtyDay;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Button customButton;
    }
}