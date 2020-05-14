namespace Bank_University
{
    partial class ChangeBankTitleForm
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
            this.SubmitButon = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PreviousTitleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateButton = new System.Windows.Forms.Button();
            this.DateTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CancelButton.Location = new System.Drawing.Point(633, 375);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(123, 62);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButon
            // 
            this.SubmitButon.Enabled = false;
            this.SubmitButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SubmitButon.Location = new System.Drawing.Point(175, 375);
            this.SubmitButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitButon.Name = "SubmitButon";
            this.SubmitButon.Size = new System.Drawing.Size(428, 62);
            this.SubmitButon.TabIndex = 6;
            this.SubmitButon.Text = "Submit";
            this.SubmitButon.UseVisualStyleBackColor = true;
            this.SubmitButon.Click += new System.EventHandler(this.SubmitButon_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TitleTextBox.Location = new System.Drawing.Point(175, 277);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(428, 30);
            this.TitleTextBox.TabIndex = 5;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter bank new title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(170, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Previous title:";
            // 
            // PreviousTitleTextBox
            // 
            this.PreviousTitleTextBox.Enabled = false;
            this.PreviousTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PreviousTitleTextBox.Location = new System.Drawing.Point(175, 157);
            this.PreviousTitleTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreviousTitleTextBox.Name = "PreviousTitleTextBox";
            this.PreviousTitleTextBox.ReadOnly = true;
            this.PreviousTitleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PreviousTitleTextBox.Size = new System.Drawing.Size(428, 30);
            this.PreviousTitleTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(170, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "New title:";
            // 
            // DateButton
            // 
            this.DateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DateButton.Location = new System.Drawing.Point(633, 9);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(124, 31);
            this.DateButton.TabIndex = 12;
            this.DateButton.Text = "<Date>";
            this.DateButton.UseVisualStyleBackColor = true;
            this.DateButton.Click += new System.EventHandler(this.DateButton_Click);
            // 
            // DateTime
            // 
            this.DateTime.Enabled = true;
            this.DateTime.Interval = 1000;
            this.DateTime.Tick += new System.EventHandler(this.DateTime_Tick);
            // 
            // ChangeBankTitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 451);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PreviousTitleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButon);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangeBankTitleForm";
            this.Text = "Change bank title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButon;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreviousTitleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Timer DateTime;
    }
}