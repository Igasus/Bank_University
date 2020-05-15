namespace Bank_University
{
    partial class DepositListForm
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DepositGridView = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnnualRateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAccountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalDepositsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NewDepositButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BankTitleLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.DateButton = new System.Windows.Forms.Button();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DepositGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DeleteButton.Location = new System.Drawing.Point(12, 554);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 40);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DepositGridView
            // 
            this.DepositGridView.AllowUserToAddRows = false;
            this.DepositGridView.AllowUserToDeleteRows = false;
            this.DepositGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DepositGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepositGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.AnnualRateColumn,
            this.DurationColumn,
            this.TotalAccountColumn,
            this.LocalDepositsColumn});
            this.DepositGridView.Location = new System.Drawing.Point(12, 80);
            this.DepositGridView.Name = "DepositGridView";
            this.DepositGridView.ReadOnly = true;
            this.DepositGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepositGridView.Size = new System.Drawing.Size(900, 468);
            this.DepositGridView.TabIndex = 13;
            this.DepositGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepositGridView_CellDoubleClick);
            this.DepositGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DepositGridView_CellMouseClick);
            // 
            // TitleColumn
            // 
            this.TitleColumn.HeaderText = "Title";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            this.TitleColumn.Width = 200;
            // 
            // AnnualRateColumn
            // 
            this.AnnualRateColumn.HeaderText = "Annual rate, %";
            this.AnnualRateColumn.Name = "AnnualRateColumn";
            this.AnnualRateColumn.ReadOnly = true;
            this.AnnualRateColumn.Width = 150;
            // 
            // DurationColumn
            // 
            this.DurationColumn.HeaderText = "Duration, months";
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.ReadOnly = true;
            this.DurationColumn.Width = 170;
            // 
            // TotalAccountColumn
            // 
            this.TotalAccountColumn.HeaderText = "Total account";
            this.TotalAccountColumn.Name = "TotalAccountColumn";
            this.TotalAccountColumn.ReadOnly = true;
            this.TotalAccountColumn.Width = 190;
            // 
            // LocalDepositsColumn
            // 
            this.LocalDepositsColumn.HeaderText = "User\'s deposits";
            this.LocalDepositsColumn.Name = "LocalDepositsColumn";
            this.LocalDepositsColumn.ReadOnly = true;
            this.LocalDepositsColumn.Width = 145;
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CloseButton.Location = new System.Drawing.Point(762, 554);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(150, 40);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NewDepositButton
            // 
            this.NewDepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NewDepositButton.Location = new System.Drawing.Point(168, 554);
            this.NewDepositButton.Name = "NewDepositButton";
            this.NewDepositButton.Size = new System.Drawing.Size(432, 40);
            this.NewDepositButton.TabIndex = 11;
            this.NewDepositButton.Text = "Create new deposit";
            this.NewDepositButton.UseVisualStyleBackColor = true;
            this.NewDepositButton.Click += new System.EventHandler(this.NewDepositButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchTextBox.Location = new System.Drawing.Point(96, 44);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(816, 30);
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search:";
            // 
            // BankTitleLabel
            // 
            this.BankTitleLabel.AutoSize = true;
            this.BankTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BankTitleLabel.Location = new System.Drawing.Point(12, 10);
            this.BankTitleLabel.MaximumSize = new System.Drawing.Size(900, 0);
            this.BankTitleLabel.MinimumSize = new System.Drawing.Size(900, 0);
            this.BankTitleLabel.Name = "BankTitleLabel";
            this.BankTitleLabel.Size = new System.Drawing.Size(900, 31);
            this.BankTitleLabel.TabIndex = 8;
            this.BankTitleLabel.Text = "_ deposits";
            this.BankTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EditButton.Location = new System.Drawing.Point(606, 554);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 40);
            this.EditButton.TabIndex = 15;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DateButton
            // 
            this.DateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DateButton.Location = new System.Drawing.Point(788, 12);
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
            this.DateTimer.Interval = 250;
            this.DateTimer.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // DepositListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 605);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DepositGridView);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.NewDepositButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BankTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DepositListForm";
            this.Text = "Deposits";
            ((System.ComponentModel.ISupportInitialize)(this.DepositGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView DepositGridView;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button NewDepositButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BankTitleLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnnualRateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAccountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalDepositsColumn;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Timer DateTimer;
    }
}