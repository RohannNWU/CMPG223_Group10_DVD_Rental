namespace CMPG223_Group10_DVD_Rental
{
    partial class Main_Menu
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
            this.bntRental = new System.Windows.Forms.Button();
            this.Inventory = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntRental
            // 
            this.bntRental.Location = new System.Drawing.Point(138, 118);
            this.bntRental.Name = "bntRental";
            this.bntRental.Size = new System.Drawing.Size(128, 23);
            this.bntRental.TabIndex = 0;
            this.bntRental.Text = "Rental";
            this.bntRental.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            this.Inventory.Location = new System.Drawing.Point(138, 189);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(128, 23);
            this.Inventory.TabIndex = 1;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(138, 264);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(128, 23);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(138, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 494);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.bntRental);
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntRental;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnExit;
    }
}