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
    public partial class UserAccountActionsForm : Form
    {
        private User _user;



        public UserAccountActionsForm()
        {
            InitializeComponent();
        }



        public UserAccountActionsForm(User user) : this()
        {
            _user = user;

            UpdateInfo();
        }



        public void UpdateInfo()
        {
            CurrentAccountTextBox.Text = String.Format("{0:0.00}", _user.Account);

            DateButton.Text = Date.CurrentDate.ToString();
        }



        private void ReplenishButton_Click(object sender, EventArgs e)
        {
            try
            {
                double amountOfMoney = Convert.ToDouble(ReplenishTextBox.Text);
                _user.Replenish(amountOfMoney);
                UpdateInfo();
            }
            catch (Exception exception)
            {
                Program.ShowErrorMessageBox(exception.Message);
            }
        }



        private void SetButton_Click(object sender, EventArgs e)
        {
            try
            {
                double amountOfMoney = Convert.ToDouble(SetTextBox.Text);
                _user.Account = amountOfMoney;
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
                double amountOfMoney = Convert.ToDouble(WithdrawTextBox.Text);
                _user.Withdraw(amountOfMoney);
                UpdateInfo();
            }
            catch (Exception exception)
            {
                Program.ShowErrorMessageBox(exception.Message);
            }
        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void TransferButton_Click(object sender, EventArgs e)
        {
            try
            {
                string recieverUsername = TransferUsernameTextBox.Text;
                User reciever = _user.Bank.FindUser(recieverUsername);
                double amountOfMoney = Convert.ToDouble(TransferAccountTextBox.Text);

                _user.TransferMoney(reciever, amountOfMoney);
                UpdateInfo();
            }
            catch (Exception exception)
            {
                Program.ShowErrorMessageBox(exception.Message);
            }
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
