namespace Bank_University
{
    partial class LocalDepositListForm
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
            this.OpenButton = new System.Windows.Forms.Button();
            this.DepositGridView = new System.Windows.Forms.DataGridView();
            this.UsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            this.NewDepositButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DateButton = new System.Windows.Forms.Button();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DepositGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Enabled = false;
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OpenButton.Location = new System.Drawing.Point(387, 553);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(370, 40);
            this.OpenButton.TabIndex = 23;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // DepositGridView
            // 
            this.DepositGridView.AllowUserToAddRows = false;
            this.DepositGridView.AllowUserToDeleteRows = false;
            this.DepositGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DepositGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepositGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsernameColumn,
            this.AccountColumn,
            this.OpenDateColumn,
            this.CloseDateColumn});
            this.DepositGridView.Location = new System.Drawing.Point(12, 79);
            this.DepositGridView.Name = "DepositGridView";
            this.DepositGridView.ReadOnly = true;
            this.DepositGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepositGridView.Size = new System.Drawing.Size(900, 468);
            this.DepositGridView.TabIndex = 21;
            this.DepositGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DepositGridView_CellMouseClick);
            this.DepositGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DepositGridView_CellMouseDoubleClick);
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.HeaderText = "Username";
            this.UsernameColumn.Name = "UsernameColumn";
            this.UsernameColumn.ReadOnly = true;
            this.UsernameColumn.Width = 215;
            // 
            // AccountColumn
            // 
            this.AccountColumn.HeaderText = "Account";
            this.AccountColumn.Name = "AccountColumn";
            this.AccountColumn.ReadOnly = true;
            this.AccountColumn.Width = 215;
            // 
            // OpenDateColumn
            // 
            this.OpenDateColumn.HeaderText = "Open date";
            this.OpenDateColumn.Name = "OpenDateColumn";
            this.OpenDateColumn.ReadOnly = true;
            this.OpenDateColumn.Width = 210;
            // 
            // CloseDateColumn
            // 
            this.CloseDateColumn.HeaderText = "Close date";
            this.CloseDateColumn.Name = "CloseDateColumn";
            this.CloseDateColumn.ReadOnly = true;
            this.CloseDateColumn.Width = 210;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BackButton.Location = new System.Drawing.Point(762, 553);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 40);
            this.BackButton.TabIndex = 20;
            this.BackButton.Text = "<-- Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NewDepositButton
            // 
            this.NewDepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NewDepositButton.Location = new System.Drawing.Point(12, 553);
            this.NewDepositButton.Name = "NewDepositButton";
            this.NewDepositButton.Size = new System.Drawing.Size(370, 40);
            this.NewDepositButton.TabIndex = 19;
            this.NewDepositButton.Text = "Open new deposit";
            this.NewDepositButton.UseVisualStyleBackColor = true;
            this.NewDepositButton.Click += new System.EventHandler(this.NewDepositButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchTextBox.Location = new System.Drawing.Point(96, 43);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(816, 30);
            this.SearchTextBox.TabIndex = 18;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.MaximumSize = new System.Drawing.Size(900, 0);
            this.TitleLabel.MinimumSize = new System.Drawing.Size(900, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(900, 31);
            this.TitleLabel.TabIndex = 16;
            this.TitleLabel.Text = "Users\' \"_\" deposits";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateButton
            // 
            this.DateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DateButton.Location = new System.Drawing.Point(788, 9);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(124, 31);
            this.DateButton.TabIndex = 24;
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
            // LocalDepositListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 602);
            this.Controls.Add(this.DateButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.DepositGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NewDepositButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LocalDepositListForm";
            this.Text = "Deposits list";
            ((System.ComponentModel.ISupportInitialize)(this.DepositGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.DataGridView DepositGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NewDepositButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CloseDateColumn;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Timer DateTimer;
    }
}