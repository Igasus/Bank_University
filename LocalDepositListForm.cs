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
    public partial class LocalDepositListForm : Form
    {
        private User _user;
        private Deposit _deposit;
        private List<LocalDeposit> _localDeposits;
        private List<LocalDeposit> _currentDeposits;
        public Bank Bank { get => Program.StartForm.SelectedBank; }



        public LocalDepositListForm()
        {
            InitializeComponent();
        }



        public LocalDepositListForm(List<LocalDeposit> localDeposits,
            User user = null, Deposit deposit = null) : this()
        {
            _user = user;
            _deposit = deposit;
            _localDeposits = localDeposits;

            if (_user != null)
                TitleLabel.Text = $"{_user.Username}' deposits";
            else if (_deposit != null)
                TitleLabel.Text = $"Users' {_deposit.Title} deposits";

            ResetInfo();
        }



        public void SetDepositGrid(List<LocalDeposit> deposits)
        {
            DepositGridView.Rows.Clear();
            deposits.ForEach(deposit => {
                string[] row = new string[]
                {
                    deposit.User.Username,
                    String.Format("{0:0.00}", deposit.Account),
                    deposit.OpenDate.ToString(),
                    deposit.CloseDate.ToString()
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
                List<LocalDeposit> result = new List<LocalDeposit>();

                if (_user != null)
                    result = _user.SearchLocalDeposits(toFind);
                else if (_deposit != null)
                    result = _deposit.SearchLocalDeposits(toFind);

                SetDepositGrid(result);
            }
            else
                SetDepositGrid(_localDeposits);
        }



        public void ResetInfo()
        {
            SearchTextBox.Text = "";
            OpenButton.Enabled = false;
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
            LocalDeposit selectedDeposit = _currentDeposits[currentRow.Index];

            OpenLocalDepositForm(selectedDeposit);
        }



        private void DepositGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow currentRow = DepositGridView.CurrentRow;

            if (currentRow == null || currentRow.Index < 0 && currentRow.Index >= _currentDeposits.Count)
                OpenButton.Enabled = false;
            else
                OpenButton.Enabled = true;
        }



        private void NewDepositButton_Click(object sender, EventArgs e)
        {
            NewLocalDepositForm form = new NewLocalDepositForm(Bank);

            if (_user != null)
                form = new NewLocalDepositForm(Bank, user: _user);
            else if (_deposit != null)
                form = new NewLocalDepositForm(Bank, deposit: _deposit);

            form.ShowDialog();
        }



        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            OpenButton.Enabled = false;

            UpdateDepositGrid();
        }



        private void OpenLocalDepositForm(LocalDeposit deposit)
        {
            LocalDepositForm form = new LocalDepositForm(deposit);
            form.ShowDialog();
        }



        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (DepositGridView.CurrentRow == null)
                return;

            int rowIndex = DepositGridView.CurrentRow.Index;
            LocalDeposit selectedDeposit = _currentDeposits[rowIndex];
            OpenLocalDepositForm(selectedDeposit);
        }



        private void DepositGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow currentRow = DepositGridView.CurrentRow;

            if (currentRow == null || currentRow.Index < 0 && currentRow.Index >= _currentDeposits.Count)
                return;

            LocalDeposit selectedDeposit = _currentDeposits[currentRow.Index];
            OpenLocalDepositForm(selectedDeposit);
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
