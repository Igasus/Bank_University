using System;
using System.Windows.Forms;
using Bank_Logic;



namespace Bank_University
{
    public partial class LoginForm : Form
    {
        private Bank _bank;



        public LoginForm()
        {
            InitializeComponent();
        }



        public LoginForm(Bank bank) : this()
        {
            _bank = bank;

            UpdateInfo();
        }



        private void UpdateSubmitButton()
        {
            if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
                SubmitButton.Enabled = false;
            else
                SubmitButton.Enabled = true;
        }



        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSubmitButton();
        }



        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSubmitButton();
        }



        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            User user = _bank.Login(username, password);
            if (user == null)
            {
                Program.ShowErrorMessageBox("Incorrect Username or password.");
                return;
            }

            ProfileForm form = new ProfileForm(user);
            form.Show();
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



        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
