using System;
using System.Windows.Forms;
using Bank_Logic;



namespace Bank_University
{
    public partial class RegisterForm : Form
    {
        public Bank Bank { get; private set; }
        public string Username { get => UsernameTextBox.Text; }
        public string Password { get => PasswordTextBox.Text; }
        



        public RegisterForm()
        {
            InitializeComponent();
        }



        public RegisterForm(Bank bank): this()
        {
            Bank = bank;

            UpdateInfo();
        }



        private void UpdateSubmitButton()
        {
            if (Username != "" && Password != "")
                SubmitButton.Enabled = true;
            else
                SubmitButton.Enabled = false;
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
            try
            {
                Bank.Register(Username, Password);
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
