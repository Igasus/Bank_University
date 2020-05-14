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
            this.label3 = new System.Windows.Forms.Label();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SpeedSubmitButton = new System.Windows.Forms.Button();
            this.CurrentSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current date";
            // 
            // CurrentDateTextBox
            // 
            this.CurrentDateTextBox.Enabled = false;
            this.CurrentDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CurrentDateTextBox.Location = new System.Drawing.Point(457, 43);
            this.CurrentDateTextBox.Name = "CurrentDateTextBox";
            this.CurrentDateTextBox.Size = new System.Drawing.Size(159, 35);
            this.CurrentDateTextBox.TabIndex = 1;
            this.CurrentDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewDateMonthCalendar
            // 
            this.NewDateMonthCalendar.Location = new System.Drawing.Point(392, 140);
            this.NewDateMonthCalendar.Name = "NewDateMonthCalendar";
            this.NewDateMonthCalendar.TabIndex = 2;
            this.NewDateMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.NewDateMonthCalendar_DateChanged);
            // 
            // NewDateTextBox
            // 
            this.NewDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NewDateTextBox.Location = new System.Drawing.Point(568, 186);
            this.NewDateTextBox.Name = "NewDateTextBox";
            this.NewDateTextBox.Size = new System.Drawing.Size(163, 30);
            this.NewDateTextBox.TabIndex = 4;
            this.NewDateTextBox.TextChanged += new System.EventHandler(this.NewDateTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(568, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set new";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SubmitButton.Location = new System.Drawing.Point(568, 267);
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
            this.CloseButton.Location = new System.Drawing.Point(202, 356);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(55, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Speed";
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SpeedTextBox.Location = new System.Drawing.Point(60, 186);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(163, 30);
            this.SpeedTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(61, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "(Seconds in day)";
            // 
            // SpeedSubmitButton
            // 
            this.SpeedSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SpeedSubmitButton.Location = new System.Drawing.Point(60, 267);
            this.SpeedSubmitButton.Name = "SpeedSubmitButton";
            this.SpeedSubmitButton.Size = new System.Drawing.Size(163, 35);
            this.SpeedSubmitButton.TabIndex = 10;
            this.SpeedSubmitButton.Text = "Sumbit";
            this.SpeedSubmitButton.UseVisualStyleBackColor = true;
            this.SpeedSubmitButton.Click += new System.EventHandler(this.SpeedSubmitButton_Click);
            // 
            // CurrentSpeedTextBox
            // 
            this.CurrentSpeedTextBox.Enabled = false;
            this.CurrentSpeedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CurrentSpeedTextBox.Location = new System.Drawing.Point(136, 43);
            this.CurrentSpeedTextBox.Name = "CurrentSpeedTextBox";
            this.CurrentSpeedTextBox.Size = new System.Drawing.Size(159, 35);
            this.CurrentSpeedTextBox.TabIndex = 12;
            this.CurrentSpeedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(121, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Current speed";
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 410);
            this.Controls.Add(this.CurrentSpeedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SpeedSubmitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SpeedTextBox);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SpeedSubmitButton;
        private System.Windows.Forms.TextBox CurrentSpeedTextBox;
        private System.Windows.Forms.Label label5;
    }
}