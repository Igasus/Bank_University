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
        private Form _previousForm;
        private bool _backAction;
        private List<Deposit> _currentDeposits;
        public Bank Bank { get; private set; }



        public DepositListForm()
        {
            InitializeComponent();
        }



        public DepositListForm(Bank bank, Form previousForm) : this()
        {
            _previousForm = previousForm;
            _backAction = false;
            Bank = bank;

            BankTitleLabel.Text = $"{Bank.Title} deposits";
            UpdateInfo();
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



        public void UpdateDepositGrid() => SetDepositGrid(Bank.Deposits);



        public void UpdateInfo()
        {
            SearchTextBox.Text = "";
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            UpdateDepositGrid();
        }



        private void DepositListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_backAction)
                _previousForm.Show();
            else
                Program.StartForm.Close();
        }



        private void BackButton_Click(object sender, EventArgs e)
        {
            _backAction = true;
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
            NewDepositForm form = new NewDepositForm(Bank, this);
            form.ShowDialog();
        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = DepositGridView.CurrentRow.Index;
            Deposit selectedDeposit = _currentDeposits[rowIndex];
            Bank.DeleteDeposit(selectedDeposit);
            UpdateInfo();
        }



        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            string toFind = SearchTextBox.Text;
            if (toFind != "")
            {
                List<Deposit> result = Bank.SearchDeposits(toFind);
                SetDepositGrid(result);
            }
            else
                UpdateDepositGrid();
        }



        private void OpenEditForm(Deposit deposit)
        {
            DepositEditForm form = new DepositEditForm(deposit, this);
            form.ShowDialog();
        }



        private void EditButton_Click(object sender, EventArgs e)
        {
            int rowIndex = DepositGridView.CurrentRow.Index;
            Deposit selectedDeposit = _currentDeposits[rowIndex];
            OpenEditForm(selectedDeposit);
        }
    }
}
