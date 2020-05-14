namespace Bank_University
{
    partial class ProfileForm
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
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AccountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AccountActionsButton = new System.Windows.Forms.Button();
            this.OpenDepositListButton = new System.Windows.Forms.Button();
            this.EditProfileButton = new System.Windows.Forms.Button();
            this.DateButton = new System.Windows.Forms.Button();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(335, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(66, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UsernameTextBox.Location = new System.Drawing.Point(71, 131);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ReadOnly = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(230, 30);
            this.UsernameTextBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NameTextBox.Location = new System.Drawing.Point(71, 246);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(230, 30);
            this.NameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(66, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SurnameTextBox.Location = new System.Drawing.Point(71, 369);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.ReadOnly = true;
            this.SurnameTextBox.Size = new System.Drawing.Size(230, 30);
            this.SurnameTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(66, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Surname";
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AccountTextBox.Location = new System.Drawing.Point(465, 131);
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.ReadOnly = true;
            this.AccountTextBox.Size = new System.Drawing.Size(230, 30);
            this.AccountTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(460, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Account";
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CloseButton.Location = new System.Drawing.Point(196, 476);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(383, 49);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AccountActionsButton
            // 
            this.AccountActionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.AccountActionsButton.Location = new System.Drawing.Point(465, 167);
            this.AccountActionsButton.Name = "AccountActionsButton";
            this.AccountActionsButton.Size = new System.Drawing.Size(230, 32);
            this.AccountActionsButton.TabIndex = 4;
            this.AccountActionsButton.Text = "Actions...";
            this.AccountActionsButton.UseVisualStyleBackColor = true;
            this.AccountActionsButton.Click += new System.EventHandler(this.AccountActionsButton_Click);
            // 
            // OpenDepositListButton
            // 
            this.OpenDepositListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OpenDepositListButton.Location = new System.Drawing.Point(465, 226);
            this.OpenDepositListButton.Name = "OpenDepositListButton";
            this.OpenDepositListButton.Size = new System.Drawing.Size(230, 50);
            this.OpenDepositListButton.TabIndex = 5;
            this.OpenDepositListButton.Text = "Deposits";
            this.OpenDepositListButton.UseVisualStyleBackColor = true;
            this.OpenDepositListButton.Click += new System.EventHandler(this.OpenDepositListButton_Click);
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EditProfileButton.Location = new System.Drawing.Point(465, 349);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Size = new System.Drawing.Size(230, 50);
            this.EditProfileButton.TabIndex = 6;
            this.EditProfileButton.Text = "Edit profile";
            this.EditProfileButton.UseVisualStyleBackColor = true;
            this.EditProfileButton.Click += new System.EventHandler(this.EditProfileButton_Click);
            // 
            // DateButton
            // 
            this.DateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DateButton.Location = new System.Drawing.Point(635, 12);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(124, 31);
            this.DateButton.TabIndex = 11;
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
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 537);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.EditProfileButton);
            this.Controls.Add(this.OpenDepositListButton);
            this.Controls.Add(this.AccountActionsButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AccountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AccountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AccountActionsButton;
        private System.Windows.Forms.Button OpenDepositListButton;
        private System.Windows.Forms.Button EditProfileButton;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Timer DateTimer;
    }
}