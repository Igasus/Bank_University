namespace Bank_University
{
    partial class NewDepositForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AnnualRateTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.DateButton = new System.Windows.Forms.Button();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CancelButton.Location = new System.Drawing.Point(592, 382);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(101, 40);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(198, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Annual rate, %:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(198, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title:";
            // 
            // AnnualRateTextBox
            // 
            this.AnnualRateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AnnualRateTextBox.Location = new System.Drawing.Point(203, 205);
            this.AnnualRateTextBox.Name = "AnnualRateTextBox";
            this.AnnualRateTextBox.Size = new System.Drawing.Size(300, 35);
            this.AnnualRateTextBox.TabIndex = 10;
            this.AnnualRateTextBox.TextChanged += new System.EventHandler(this.AnnualRateTextBox_TextChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TitleTextBox.Location = new System.Drawing.Point(203, 107);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(300, 35);
            this.TitleTextBox.TabIndex = 9;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Enabled = false;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SubmitButton.Location = new System.Drawing.Point(203, 382);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(300, 40);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Create new deposit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(198, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Duration i months:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.DurationTextBox.Location = new System.Drawing.Point(203, 310);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(300, 35);
            this.DurationTextBox.TabIndex = 14;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // DateButton
            // 
            this.DateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DateButton.Location = new System.Drawing.Point(569, 9);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(124, 31);
            this.DateButton.TabIndex = 16;
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
            // NewDepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 434);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnnualRateTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewDepositForm";
            this.Text = "New deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AnnualRateTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Timer DateTimer;
    }
}