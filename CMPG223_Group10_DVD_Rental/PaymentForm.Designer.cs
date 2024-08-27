namespace CMPG223_Group10_DVD_Rental
{
    partial class PaymentForm
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
            this.cashButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.dueLabel = new System.Windows.Forms.Label();
            this.paidLabel = new System.Windows.Forms.Label();
            this.cardButton = new System.Windows.Forms.Button();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.inputError = new System.Windows.Forms.ErrorProvider(this.components);
            this.paymentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).BeginInit();
            this.SuspendLayout();
            // 
            // cashButton
            // 
            this.cashButton.Location = new System.Drawing.Point(54, 38);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(138, 50);
            this.cashButton.TabIndex = 0;
            this.cashButton.Text = "Cash";
            this.cashButton.UseVisualStyleBackColor = true;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(232, 39);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Fine Payment";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(12, 79);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(83, 16);
            this.clientLabel.TabIndex = 2;
            this.clientLabel.Text = "Client Name:";
            // 
            // dueLabel
            // 
            this.dueLabel.AutoSize = true;
            this.dueLabel.Location = new System.Drawing.Point(12, 132);
            this.dueLabel.Name = "dueLabel";
            this.dueLabel.Size = new System.Drawing.Size(83, 16);
            this.dueLabel.TabIndex = 3;
            this.dueLabel.Text = "Amount Due:";
            // 
            // paidLabel
            // 
            this.paidLabel.AutoSize = true;
            this.paidLabel.Location = new System.Drawing.Point(12, 184);
            this.paidLabel.Name = "paidLabel";
            this.paidLabel.Size = new System.Drawing.Size(86, 16);
            this.paidLabel.TabIndex = 4;
            this.paidLabel.Text = "Amount Paid:";
            // 
            // cardButton
            // 
            this.cardButton.Location = new System.Drawing.Point(54, 105);
            this.cardButton.Name = "cardButton";
            this.cardButton.Size = new System.Drawing.Size(138, 50);
            this.cardButton.TabIndex = 6;
            this.cardButton.Text = "Card";
            this.cardButton.UseVisualStyleBackColor = true;
            this.cardButton.Click += new System.EventHandler(this.cardButton_Click);
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.cardButton);
            this.paymentGroupBox.Controls.Add(this.cashButton);
            this.paymentGroupBox.Location = new System.Drawing.Point(12, 231);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(241, 171);
            this.paymentGroupBox.TabIndex = 7;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment Method";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(104, 181);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(115, 22);
            this.amountTextBox.TabIndex = 8;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // inputError
            // 
            this.inputError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.inputError.ContainerControl = this;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 418);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.paidLabel);
            this.Controls.Add(this.dueLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.headerLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Form";
            this.paymentGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label dueLabel;
        private System.Windows.Forms.Label paidLabel;
        private System.Windows.Forms.Button cardButton;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ErrorProvider inputError;
    }
}