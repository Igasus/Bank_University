namespace Bank_University
{
    partial class BankMenuForm
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
            this.BankTitlelabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.DepositsButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.DateButton = new System.Windows.Forms.Button();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BankTitlelabel
            // 
            this.BankTitlelabel.AutoSize = true;
            this.BankTitlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BankTitlelabel.Location = new System.Drawing.Point(210, 9);
            this.BankTitlelabel.Margin = new System.Windows.Forms.Padding(0);
            this.BankTitlelabel.MaximumSize = new System.Drawing.Size(310, 0);
            this.BankTitlelabel.MinimumSize = new System.Drawing.Size(310, 0);
            this.BankTitlelabel.Name = "BankTitlelabel";
            this.BankTitlelabel.Size = new System.Drawing.Size(310, 31);
            this.BankTitlelabel.TabIndex = 0;
            this.BankTitlelabel.Text = "<Bank.Title>";
            this.BankTitlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BackButton.Location = new System.Drawing.Point(140, 344);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(438, 66);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "<--  Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LoginButton.Location = new System.Drawing.Point(37, 100);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(300, 66);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.RegisterButton.Location = new System.Drawing.Point(385, 100);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(300, 66);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // DepositsButton
            // 
            this.DepositsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.DepositsButton.Location = new System.Drawing.Point(385, 221);
            this.DepositsButton.Name = "DepositsButton";
            this.DepositsButton.Size = new System.Drawing.Size(300, 66);
            this.DepositsButton.TabIndex = 4;
            this.DepositsButton.Text = "Bank deposits";
            this.DepositsButton.UseVisualStyleBackColor = true;
            this.DepositsButton.Click += new System.EventHandler(this.DepositsButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.UsersButton.Location = new System.Drawing.Point(37, 221);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(300, 66);
            this.UsersButton.TabIndex = 5;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // DateButton
            // 
            this.DateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DateButton.Location = new System.Drawing.Point(585, 9);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(124, 31);
            this.DateButton.TabIndex = 6;
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
            // BankMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 463);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.DepositsButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BankTitlelabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BankMenuForm";
            this.Text = "Bank menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BankMenuForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BankTitlelabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button DepositsButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Timer DateTimer;
    }
}