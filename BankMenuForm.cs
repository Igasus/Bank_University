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
    public partial class BankMenuForm : Form
    {
        private bool _backAction;
        public Bank Bank { get; private set; }



        public BankMenuForm()
        {
            InitializeComponent();
        }



        public BankMenuForm(Bank bank): this()
        {
            _backAction = false;
            Bank = bank;
            BankTitlelabel.Text = Bank.Title;

            UpdateInfo();
        }



        private void BankMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_backAction)
                Program.StartForm.Show();
            else
                Program.StartForm.Close();
        }



        private void BackButton_Click(object sender, EventArgs e)
        {
            _backAction = true;
            Close();
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm(Bank);
            form.Show();
        }



        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm(Bank);
            form.Show();
        }



        private void UsersButton_Click(object sender, EventArgs e)
        {
            UserListForm form = new UserListForm(Bank);
            form.Show();
        }



        private void DepositsButton_Click(object sender, EventArgs e)
        {
            DepositListForm form = new DepositListForm(Bank);
            form.Show();
        }



        private void DateButton_Click(object sender, EventArgs e)
        {
            DateForm form = new DateForm();
            form.Show();
        }



        public void UpdateInfo()
        {
            DateButton.Text = Date.CurrentDate.ToString();
        }



        private void DateTimer_Tick(object sender, EventArgs e)
        {
            UpdateInfo();
        }
    }
}
