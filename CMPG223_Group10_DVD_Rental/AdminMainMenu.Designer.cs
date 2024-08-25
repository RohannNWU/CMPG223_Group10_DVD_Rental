namespace CMPG223_Group10_DVD_Rental
{
    partial class AdminMainMenu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvdsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dvdsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1082, 30);
            this.menuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 26);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.quitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // dvdsToolStripMenuItem
            // 
            this.dvdsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.dvdsToolStripMenuItem.Name = "dvdsToolStripMenuItem";
            this.dvdsToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.dvdsToolStripMenuItem.Text = "&DVDs";
            this.dvdsToolStripMenuItem.Click += new System.EventHandler(this.dvdsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.customersToolStripMenuItem.Text = "&Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.employeesToolStripMenuItem.Text = "&Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.helpGuideToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // helpGuideToolStripMenuItem
            // 
            this.helpGuideToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.helpGuideToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.helpGuideToolStripMenuItem.Name = "helpGuideToolStripMenuItem";
            this.helpGuideToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.helpGuideToolStripMenuItem.Text = "&Help Guide";
            this.helpGuideToolStripMenuItem.Click += new System.EventHandler(this.helpGuideToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(198)))), ((int)(((byte)(225)))));
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.windowsToolStripMenuItem.Text = "&Windows";
            // 
            // AdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "AdminMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVD Rentals Dashboard";
            this.Load += new System.EventHandler(this.AdminMainMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dvdsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
    }
}