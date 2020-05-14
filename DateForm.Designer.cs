namespace Bank_University
{
    partial class DateForm
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
            this.CurrentDateTextBox = new System.Windows.Forms.TextBox();
            this.NewDateMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.NewDateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(111, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current date";
            // 
            // CurrentDateTextBox
            // 
            this.CurrentDateTextBox.Enabled = false;
            this.CurrentDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CurrentDateTextBox.Location = new System.Drawing.Point(114, 53);
            this.CurrentDateTextBox.Name = "CurrentDateTextBox";
            this.CurrentDateTextBox.Size = new System.Drawing.Size(159, 35);
            this.CurrentDateTextBox.TabIndex = 1;
            // 
            // NewDateMonthCalendar
            // 
            this.NewDateMonthCalendar.Location = new System.Drawing.Point(18, 143);
            this.NewDateMonthCalendar.Name = "NewDateMonthCalendar";
            this.NewDateMonthCalendar.TabIndex = 2;
            this.NewDateMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.NewDateMonthCalendar_DateChanged);
            // 
            // NewDateTextBox
            // 
            this.NewDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NewDateTextBox.Location = new System.Drawing.Point(194, 175);
            this.NewDateTextBox.Name = "NewDateTextBox";
            this.NewDateTextBox.Size = new System.Drawing.Size(163, 30);
            this.NewDateTextBox.TabIndex = 4;
            this.NewDateTextBox.TextChanged += new System.EventHandler(this.NewDateTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(194, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set new";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SubmitButton.Location = new System.Drawing.Point(194, 270);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(163, 35);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Sumbit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CloseButton.Location = new System.Drawing.Point(18, 356);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(339, 42);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DateTimer
            // 
            this.DateTimer.Enabled = true;
            this.DateTimer.Interval = 1000;
            this.DateTimer.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 410);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.NewDateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewDateMonthCalendar);
            this.Controls.Add(this.CurrentDateTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DateForm";
            this.Text = "Date settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurrentDateTextBox;
        private System.Windows.Forms.MonthCalendar NewDateMonthCalendar;
        private System.Windows.Forms.TextBox NewDateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Timer DateTimer;
    }
}