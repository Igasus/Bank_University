using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Logic;



namespace Bank_University
{
    public partial class DepositListForm : Form
    {
        private List<Deposit> _currentDeposits;
        public Bank Bank { get; private set; }



        public DepositListForm()
        {
            InitializeComponent();
        }



        public DepositListForm(Bank bank) : this()
        {
            Bank = bank;

            BankTitleLabel.Text = $"{Bank.Title} deposits";
            ResetInfo();
        }



        public void SetDepositGrid(List<Deposit> deposits)
        {
            DepositGridView.Rows.Clear();
            deposits.ForEach(deposit => {
                string[] row = new string[]
                {
                    deposit.Title,
                    String.Format("{0:0.00}", deposit.AnnualRate * 100),
                    deposit.Duration.ToString(),
                    String.Format("{0:0.00}", deposit.TotalAccount),
                    deposit.LocalDeposits.Count.ToString()
                };
                DepositGridView.Rows.Add(row);
            });
            _currentDeposits = deposits;
        }



        public void UpdateDepositGrid()
        {
            string toFind = SearchTextBox.Text;
            if (toFind != "")
            {
                List<Deposit> result = Bank.SearchDeposits(toFind);
                SetDepositGrid(result);
            }
            else
                SetDepositGrid(Bank.Deposits);
        }



        public void ResetInfo()
        {
            SearchTextBox.Text = "";
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            UpdateDepositGrid();
        }



        public void UpdateInfo()
        {
            UpdateDepositGrid();

            DateButton.Text = Date.CurrentDate.ToString();
        }



        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void DepositGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = DepositGridView.CurrentRow;

            if (currentRow == null || currentRow.Index < 0 && currentRow.Index >= _currentDeposits.Count)
                return;
            Deposit selectedDeposit = _currentDeposits[currentRow.Index];

            OpenEditForm(selectedDeposit);
        }



        private void DepositGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow currentRow = DepositGridView.CurrentRow;

            if (currentRow == null || currentRow.Index < 0 && currentRow.Index >= _currentDeposits.Count)
            {
                DeleteButton.Enabled = false;
                EditButton.Enabled = false;
            }
            else
            {
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;
            }
        }



        private void NewDepositButton_Click(object sender, EventArgs e)
        {
            NewDepositForm form = new NewDepositForm(Bank);
            form.ShowDialog();
        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = DepositGridView.CurrentRow.Index;
            Deposit selectedDeposit = _currentDeposits[rowIndex];
            Bank.DeleteDeposit(selectedDeposit);
            ResetInfo();
        }



        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;

            UpdateDepositGrid();
        }



        private void OpenEditForm(Deposit deposit)
        {
            DepositEditForm form = new DepositEditForm(deposit);
            form.ShowDialog();
        }



        private void EditButton_Click(object sender, EventArgs e)
        {
            int rowIndex = DepositGridView.CurrentRow.Index;
            Deposit selectedDeposit = _currentDeposits[rowIndex];
            OpenEditForm(selectedDeposit);
        }


        private void DateButton_Click(object sender, EventArgs e)
        {
            DateForm form = new DateForm();
            form.Show();
        }



        private void DateTimer_Tick(object sender, EventArgs e)
        {
            UpdateInfo();
        }

    }
}
