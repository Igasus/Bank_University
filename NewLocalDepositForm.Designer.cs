namespace Bank_University
{
    partial class NewLocalDepositForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameComboBox = new System.Windows.Forms.ComboBox();
            this.DepositComboBox = new System.Windows.Forms.ComboBox();
            this.SeedCapitalTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DateButton = new System.Windows.Forms.Button();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New user\'s deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(192, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(192, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bank deposit:";
            // 
            // UsernameComboBox
            // 
            this.UsernameComboBox.Enabled = false;
            this.UsernameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UsernameComboBox.FormattingEnabled = true;
            this.UsernameComboBox.Location = new System.Drawing.Point(197, 110);
            this.UsernameComboBox.Name = "UsernameComboBox";
            this.UsernameComboBox.Size = new System.Drawing.Size(270, 33);
            this.UsernameComboBox.TabIndex = 3;
            // 
            // DepositComboBox
            // 
            this.DepositComboBox.Enabled = false;
            this.DepositComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DepositComboBox.FormattingEnabled = true;
            this.DepositComboBox.Location = new System.Drawing.Point(197, 204);
            this.DepositComboBox.Name = "DepositComboBox";
            this.DepositComboBox.Size = new System.Drawing.Size(270, 33);
            this.DepositComboBox.TabIndex = 4;
            // 
            // SeedCapitalTextBox
            // 
            this.SeedCapitalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SeedCapitalTextBox.Location = new System.Drawing.Point(197, 303);
            this.SeedCapitalTextBox.Name = "SeedCapitalTextBox";
            this.SeedCapitalTextBox.Size = new System.Drawing.Size(270, 30);
            this.SeedCapitalTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(192, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seed capital";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SubmitButton.Location = new System.Drawing.Point(197, 361);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(270, 39);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CancelButton.Location = new System.Drawing.Point(557, 361);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(103, 39);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DateButton
            // 
            this.DateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DateButton.Location = new System.Drawing.Point(536, 12);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(124, 31);
            this.DateButton.TabIndex = 9;
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
            // NewLocalDepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 412);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SeedCapitalTextBox);
            this.Controls.Add(this.DepositComboBox);
            this.Controls.Add(this.UsernameComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewLocalDepositForm";
            this.Text = "New user\'s deposit creating";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox UsernameComboBox;
        private System.Windows.Forms.ComboBox DepositComboBox;
        private System.Windows.Forms.TextBox SeedCapitalTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Timer DateTimer;
    }
}