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
    public partial class LocalDepositForm : Form
    {
        private LocalDeposit _deposit;



        public LocalDepositForm()
        {
            InitializeComponent();
        }



        public LocalDepositForm(LocalDeposit deposit) : this()
        {
            _deposit = deposit;

            FormTitleLabel.Text = $"{_deposit.User.Username}' deposit";

            UsernameTextBox.Text = _deposit.User.Username;
            TitleTextBox.Text = _deposit.Title;

            UpdateInfo();
        }



        private void UpdateHistoryListView()
        {
            HistoryListView.Items.Clear();

            foreach (TransferAction action in _deposit.History)
            {
                string[] row = new string[]
                {
                    action.Date.ToString(),
                    action.GetStringType(),
                    String.Format("{0:0.00}", action.AmountOfMoney)
                };
                ListViewItem item = new ListViewItem(row);
                HistoryListView.Items.Add(item);
            }
        }



        private void UpdateInfo()
        {
            UserAccountTextBox.Text = String.Format("{0:0.00}", _deposit.User.Account);
            DepositAccountTextBox.Text = String.Format("{0:0.00}", _deposit.Account);

            AnnualRateTextBox.Text = String.Format("{0:0.00}%", _deposit.AnnualRate * 100);
            DurationTextBox.Text = $"{_deposit.Duration} months";

            OpenDateTextBox.Text = _deposit.OpenDate.ToString();
            CloseDateTextBox.Text = _deposit.CloseDate.ToString();

            UpdateHistoryListView();

            DateButton.Text = Date.CurrentDate.ToString();
        }



        private void ReplenishButton_Click(object sender, EventArgs e)
        {
            try
            {
                double amountOfMoney = Convert.ToDouble(TransferMoneyTextBox.Text);
                _deposit.Replenish(amountOfMoney);
                UpdateInfo();
            }
            catch (Exception exception)
            {
                Program.ShowErrorMessageBox(exception.Message);
            }
        }



        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                double amountOfMoney = Convert.ToDouble(TransferMoneyTextBox.Text);
                _deposit.Withdraw(amountOfMoney);
                UpdateInfo();
            }
            catch (Exception exception)
            {
                Program.ShowErrorMessageBox(exception.Message);
            }
        }



        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        


        private void CloseDepositButton_Click(object sender, EventArgs e)
        {
            _deposit.Close();
            Close();
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
