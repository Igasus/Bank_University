namespace Bank_University
{
    partial class UserAccountActionsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentAccountTextBox = new System.Windows.Forms.TextBox();
            this.SetTextBox = new System.Windows.Forms.TextBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.ReplenishButton = new System.Windows.Forms.Button();
            this.ReplenishTextBox = new System.Windows.Forms.TextBox();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.WithdrawTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TransferButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TransferUsernameTextBox = new System.Windows.Forms.TextBox();
            this.TransferAccountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateButton = new System.Windows.Forms.Button();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(343, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current account";
            // 
            // CurrentAccountTextBox
            // 
            this.CurrentAccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CurrentAccountTextBox.Location = new System.Drawing.Point(285, 74);
            this.CurrentAccountTextBox.Name = "CurrentAccountTextBox";
            this.CurrentAccountTextBox.ReadOnly = true;
            this.CurrentAccountTextBox.Size = new System.Drawing.Size(329, 35);
            this.CurrentAccountTextBox.TabIndex = 0;
            this.CurrentAccountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetTextBox
            // 
            this.SetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SetTextBox.Location = new System.Drawing.Point(352, 158);
            this.SetTextBox.Name = "SetTextBox";
            this.SetTextBox.Size = new System.Drawing.Size(202, 30);
            this.SetTextBox.TabIndex = 3;
            // 
            // SetButton
            // 
            this.SetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SetButton.Location = new System.Drawing.Point(352, 194);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(202, 33);
            this.SetButton.TabIndex = 4;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // ReplenishButton
            // 
            this.ReplenishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ReplenishButton.Location = new System.Drawing.Point(71, 194);
            this.ReplenishButton.Name = "ReplenishButton";
            this.ReplenishButton.Size = new System.Drawing.Size(202, 33);
            this.ReplenishButton.TabIndex = 2;
            this.ReplenishButton.Text = "Replenish";
            this.ReplenishButton.UseVisualStyleBackColor = true;
            this.ReplenishButton.Click += new System.EventHandler(this.ReplenishButton_Click);
            // 
            // ReplenishTextBox
            // 
            this.ReplenishTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ReplenishTextBox.Location = new System.Drawing.Point(71, 158);
            this.ReplenishTextBox.Name = "ReplenishTextBox";
            this.ReplenishTextBox.Size = new System.Drawing.Size(202, 30);
            this.ReplenishTextBox.TabIndex = 1;
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WithdrawButton.Location = new System.Drawing.Point(627, 194);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(202, 33);
            this.WithdrawButton.TabIndex = 6;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // WithdrawTextBox
            // 
            this.WithdrawTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WithdrawTextBox.Location = new System.Drawing.Point(627, 158);
            this.WithdrawTextBox.Name = "WithdrawTextBox";
            this.WithdrawTextBox.Size = new System.Drawing.Size(202, 30);
            this.WithdrawTextBox.TabIndex = 5;
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CloseButton.Location = new System.Drawing.Point(285, 427);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(329, 55);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TransferButton
            // 
            this.TransferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TransferButton.Location = new System.Drawing.Point(560, 304);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(165, 68);
            this.TransferButton.TabIndex = 11;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(181, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(181, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Amount of money";
            // 
            // TransferUsernameTextBox
            // 
            this.TransferUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TransferUsernameTextBox.Location = new System.Drawing.Point(352, 306);
            this.TransferUsernameTextBox.Name = "TransferUsernameTextBox";
            this.TransferUsernameTextBox.Size = new System.Drawing.Size(202, 30);
            this.TransferUsernameTextBox.TabIndex = 14;
            // 
            // TransferAccountTextBox
            // 
            this.TransferAccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TransferAccountTextBox.Location = new System.Drawing.Point(352, 342);
            this.TransferAccountTextBox.Name = "TransferAccountTextBox";
            this.TransferAccountTextBox.Size = new System.Drawing.Size(202, 30);
            this.TransferAccountTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(378, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Transfer money";
            // 
            // DateButton
            // 
            this.DateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DateButton.Location = new System.Drawing.Point(750, 12);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(124, 31);
            this.DateButton.TabIndex = 17;
            this.DateButton.Text = "<Date>";
            this.DateButton.UseVisualStyleBackColor = true;
            this.DateButton.Click += new System.EventHandler(this.DateButton_Click);
            // 
            // DateTimer
            // 
            this.DateTimer.Enabled = true;
            this.DateTimer.Interval = 1000;
            this.DateTimer.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // UserAccountActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 513);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TransferAccountTextBox);
            this.Controls.Add(this.TransferUsernameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.WithdrawTextBox);
            this.Controls.Add(this.ReplenishButton);
            this.Controls.Add(this.ReplenishTextBox);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.SetTextBox);
            this.Controls.Add(this.CurrentAccountTextBox);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserAccountActionsForm";
            this.Text = "Account actions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CurrentAccountTextBox;
        private System.Windows.Forms.TextBox SetTextBox;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button ReplenishButton;
        private System.Windows.Forms.TextBox ReplenishTextBox;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.TextBox WithdrawTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TransferUsernameTextBox;
        private System.Windows.Forms.TextBox TransferAccountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Timer DateTimer;
    }
}