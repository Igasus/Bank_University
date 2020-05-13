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
    public partial class NewLocalDepositForm : Form
    {
        private Form _previousForm;
        private Bank _bank;
        private User _user;
        private Deposit _deposit;



        public NewLocalDepositForm()
        {
            InitializeComponent();
        }



        public NewLocalDepositForm(Bank bank, Form previousForm, User user = null, Deposit deposit = null) : this()
        {
            _previousForm = previousForm;
            _bank = bank;
            _user = user;
            _deposit = deposit;

            if (_user == null)
            {
                UsernameComboBox.Enabled = true;
                _bank.Users.ForEach(bankUser => UsernameComboBox.Items.Add(bankUser.Username));
            }
            else
                UsernameComboBox.Text = _user.Username;


            if (_deposit == null)
            {
                DepositComboBox.Enabled = true;
                _bank.Deposits.ForEach(bankDepoit => DepositComboBox.Items.Add(bankDepoit.Title));
            }
            else
                DepositComboBox.Text = _deposit.Title;
        }



        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = _user == null ? _bank.FindUser(UsernameComboBox.Text) : _user;
                Deposit deposit = _deposit == null ? _bank.FindDeposit(DepositComboBox.Text) : _deposit;
                double seedCapital = Convert.ToDouble(SeedCapitalTextBox.Text);

                user.OpenDeposit(deposit, seedCapital);

                Close();
            }
            catch (Exception exception)
            {
                Program.ShowErrorMessageBox(exception.Message);
            }

        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void NewLocalDepositForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ((LocalDepositListForm)_previousForm).UpdateInfo();
            }
            catch (Exception) { }
        }
    }
}
