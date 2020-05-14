namespace Bank_University
{
    partial class DepositEditForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.NewDurationTextBox = new System.Windows.Forms.TextBox();
            this.OldDurationTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NewAnnualRateTextBox = new System.Windows.Forms.TextBox();
            this.OldAnnualRateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NewTitleTextBox = new System.Windows.Forms.TextBox();
            this.OldTitleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LocalDepositListButton = new System.Windows.Forms.Button();
            this.DateButton = new System.Windows.Forms.Button();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CancelButton.Location = new System.Drawing.Point(642, 355);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 49);
            this.CancelButton.TabIndex = 67;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SubmitButton.Location = new System.Drawing.Point(12, 355);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(624, 49);
            this.SubmitButton.TabIndex = 66;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // NewDurationTextBox
            // 
            this.NewDurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NewDurationTextBox.Location = new System.Drawing.Point(472, 278);
            this.NewDurationTextBox.Name = "NewDurationTextBox";
            this.NewDurationTextBox.Size = new System.Drawing.Size(270, 30);
            this.NewDurationTextBox.TabIndex = 58;
            // 
            // OldDurationTextBox
            // 
            this.OldDurationTextBox.Enabled = false;
            this.OldDurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OldDurationTextBox.Location = new System.Drawing.Point(472, 239);
            this.OldDurationTextBox.Name = "OldDurationTextBox";
            this.OldDurationTextBox.Size = new System.Drawing.Size(270, 30);
            this.OldDurationTextBox.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(415, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "New:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(417, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 25);
            this.label9.TabIndex = 55;
            this.label9.Text = "Old:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label10.Location = new System.Drawing.Point(415, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 29);
            this.label10.TabIndex = 54;
            this.label10.Text = "Duration, months";
            // 
            // NewAnnualRateTextBox
            // 
            this.NewAnnualRateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NewAnnualRateTextBox.Location = new System.Drawing.Point(472, 130);
            this.NewAnnualRateTextBox.Name = "NewAnnualRateTextBox";
            this.NewAnnualRateTextBox.Size = new System.Drawing.Size(270, 30);
            this.NewAnnualRateTextBox.TabIndex = 48;
            // 
            // OldAnnualRateTextBox
            // 
            this.OldAnnualRateTextBox.Enabled = false;
            this.OldAnnualRateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OldAnnualRateTextBox.Location = new System.Drawing.Point(472, 91);
            this.OldAnnualRateTextBox.Name = "OldAnnualRateTextBox";
            this.OldAnnualRateTextBox.Size = new System.Drawing.Size(270, 30);
            this.OldAnnualRateTextBox.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(415, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "New:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(417, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Old:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(415, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 29);
            this.label7.TabIndex = 44;
            this.label7.Text = "Annual rate, %";
            // 
            // NewTitleTextBox
            // 
            this.NewTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NewTitleTextBox.Location = new System.Drawing.Point(69, 130);
            this.NewTitleTextBox.Name = "NewTitleTextBox";
            this.NewTitleTextBox.Size = new System.Drawing.Size(270, 30);
            this.NewTitleTextBox.TabIndex = 43;
            // 
            // OldTitleTextBox
            // 
            this.OldTitleTextBox.Enabled = false;
            this.OldTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OldTitleTextBox.Location = new System.Drawing.Point(69, 91);
            this.OldTitleTextBox.Name = "OldTitleTextBox";
            this.OldTitleTextBox.Size = new System.Drawing.Size(270, 30);
            this.OldTitleTextBox.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "New:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(14, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Old:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(298, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Edit deposit data";
            // 
            // LocalDepositListButton
            // 
            this.LocalDepositListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LocalDepositListButton.Location = new System.Drawing.Point(69, 239);
            this.LocalDepositListButton.Name = "LocalDepositListButton";
            this.LocalDepositListButton.Size = new System.Drawing.Size(270, 69);
            this.LocalDepositListButton.TabIndex = 65;
            this.LocalDepositListButton.Text = "Users deposits list";
            this.LocalDepositListButton.UseVisualStyleBackColor = true;
            this.LocalDepositListButton.Click += new System.EventHandler(this.LocalDepositListButton_Click);
            // 
            // DateButton
            // 
            this.DateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DateButton.Location = new System.Drawing.Point(668, 12);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(124, 31);
            this.DateButton.TabIndex = 68;
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
            // DepositEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 414);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.LocalDepositListButton);
            this.Controls.Add(this.NewDurationTextBox);
            this.Controls.Add(this.OldDurationTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NewAnnualRateTextBox);
            this.Controls.Add(this.OldAnnualRateTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NewTitleTextBox);
            this.Controls.Add(this.OldTitleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DepositEditForm";
            this.Text = "Edit deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox NewDurationTextBox;
        private System.Windows.Forms.TextBox OldDurationTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NewAnnualRateTextBox;
        private System.Windows.Forms.TextBox OldAnnualRateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NewTitleTextBox;
        private System.Windows.Forms.TextBox OldTitleTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LocalDepositListButton;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Timer DateTimer;
    }
}