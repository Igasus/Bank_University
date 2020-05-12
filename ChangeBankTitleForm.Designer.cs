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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButon = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PreviousTitleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CancelButton.Location = new System.Drawing.Point(294, 157);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(102, 40);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButon
            // 
            this.SubmitButon.Enabled = false;
            this.SubmitButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SubmitButon.Location = new System.Drawing.Point(31, 157);
            this.SubmitButon.Name = "SubmitButon";
            this.SubmitButon.Size = new System.Drawing.Size(257, 40);
            this.SubmitButon.TabIndex = 6;
            this.SubmitButon.Text = "Submit";
            this.SubmitButon.UseVisualStyleBackColor = true;
            this.SubmitButon.Click += new System.EventHandler(this.SubmitButon_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TitleTextBox.Location = new System.Drawing.Point(31, 116);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(365, 35);
            this.TitleTextBox.TabIndex = 5;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter bank new title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Previous title:";
            // 
            // PreviousTitleTextBox
            // 
            this.PreviousTitleTextBox.Enabled = false;
            this.PreviousTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.PreviousTitleTextBox.Location = new System.Drawing.Point(188, 74);
            this.PreviousTitleTextBox.Name = "PreviousTitleTextBox";
            this.PreviousTitleTextBox.ReadOnly = true;
            this.PreviousTitleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PreviousTitleTextBox.Size = new System.Drawing.Size(208, 35);
            this.PreviousTitleTextBox.TabIndex = 9;
            // 
            // ChangeBankTitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 229);
            this.Controls.Add(this.PreviousTitleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButon);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label1);
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
    }
}