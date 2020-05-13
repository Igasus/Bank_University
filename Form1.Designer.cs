namespace Bank_University
{
    partial class BankListForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BankListBox = new System.Windows.Forms.ListBox();
            this.CreateBankButton = new System.Windows.Forms.Button();
            this.OpenBankButton = new System.Windows.Forms.Button();
            this.ChangeBankTitleButton = new System.Windows.Forms.Button();
            this.DeleteBankButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(213, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Bank";
            // 
            // BankListBox
            // 
            this.BankListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BankListBox.FormattingEnabled = true;
            this.BankListBox.ItemHeight = 31;
            this.BankListBox.Location = new System.Drawing.Point(12, 71);
            this.BankListBox.Name = "BankListBox";
            this.BankListBox.Size = new System.Drawing.Size(667, 376);
            this.BankListBox.TabIndex = 1;
            this.BankListBox.SelectedIndexChanged += new System.EventHandler(this.BankListBox_SelectedIndexChanged);
            this.BankListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BankListBox_MouseDoubleClick);
            // 
            // CreateBankButton
            // 
            this.CreateBankButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CreateBankButton.Location = new System.Drawing.Point(347, 459);
            this.CreateBankButton.Name = "CreateBankButton";
            this.CreateBankButton.Size = new System.Drawing.Size(333, 66);
            this.CreateBankButton.TabIndex = 2;
            this.CreateBankButton.Text = "Create new bank";
            this.CreateBankButton.UseVisualStyleBackColor = true;
            this.CreateBankButton.Click += new System.EventHandler(this.CreateBankButton_Click);
            // 
            // OpenBankButton
            // 
            this.OpenBankButton.Enabled = false;
            this.OpenBankButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OpenBankButton.Location = new System.Drawing.Point(11, 459);
            this.OpenBankButton.Name = "OpenBankButton";
            this.OpenBankButton.Size = new System.Drawing.Size(333, 66);
            this.OpenBankButton.TabIndex = 3;
            this.OpenBankButton.Text = "Open bank";
            this.OpenBankButton.UseVisualStyleBackColor = true;
            this.OpenBankButton.Click += new System.EventHandler(this.OpenBankButton_Click);
            // 
            // ChangeBankTitleButton
            // 
            this.ChangeBankTitleButton.Enabled = false;
            this.ChangeBankTitleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ChangeBankTitleButton.Location = new System.Drawing.Point(11, 528);
            this.ChangeBankTitleButton.Name = "ChangeBankTitleButton";
            this.ChangeBankTitleButton.Size = new System.Drawing.Size(333, 66);
            this.ChangeBankTitleButton.TabIndex = 5;
            this.ChangeBankTitleButton.Text = "Change bank title";
            this.ChangeBankTitleButton.UseVisualStyleBackColor = true;
            this.ChangeBankTitleButton.Click += new System.EventHandler(this.ChangeBankTitleButton_Click);
            // 
            // DeleteBankButton
            // 
            this.DeleteBankButton.Enabled = false;
            this.DeleteBankButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DeleteBankButton.Location = new System.Drawing.Point(347, 528);
            this.DeleteBankButton.Name = "DeleteBankButton";
            this.DeleteBankButton.Size = new System.Drawing.Size(333, 66);
            this.DeleteBankButton.TabIndex = 4;
            this.DeleteBankButton.Text = "Delete bank";
            this.DeleteBankButton.UseVisualStyleBackColor = true;
            this.DeleteBankButton.Click += new System.EventHandler(this.DeleteBankButton_Click);
            // 
            // BankListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 606);
            this.Controls.Add(this.ChangeBankTitleButton);
            this.Controls.Add(this.DeleteBankButton);
            this.Controls.Add(this.OpenBankButton);
            this.Controls.Add(this.CreateBankButton);
            this.Controls.Add(this.BankListBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BankListForm";
            this.Text = "Choose Bank";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BankListForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox BankListBox;
        private System.Windows.Forms.Button CreateBankButton;
        private System.Windows.Forms.Button OpenBankButton;
        private System.Windows.Forms.Button ChangeBankTitleButton;
        private System.Windows.Forms.Button DeleteBankButton;
    }
}

