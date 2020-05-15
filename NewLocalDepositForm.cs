using System;
using System.Windows.Forms;
using Bank_Logic;



namespace Bank_University
{
    public partial class NewLocalDepositForm : Form
    {
        private Bank _bank;
        private User _user;
        private Deposit _deposit;



        public NewLocalDepositForm()
        {
            InitializeComponent();
        }



        public NewLocalDepositForm(Bank bank, User user = null, Deposit deposit = null) : this()
        {
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

            UpdateInfo();
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



        public void UpdateInfo()
        {
            DateButton.Text = Date.CurrentDate.ToString();
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
