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
        private Form _previousForm;
        private bool _backAction;
        public Bank Bank { get; private set; }



        public BankMenuForm()
        {
            InitializeComponent();
        }



        public BankMenuForm(Bank bank, Form previousForm): this()
        {
            _previousForm = previousForm;
            _backAction = false;
            Bank = bank;
            BankTitlelabel.Text = Bank.Title;
        }



        private void BankMenuForm_FormClosed(object sender, FormClosedEventArgs e)
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



        private void LoginButton_Click(object sender, EventArgs e)
        {

        }



        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(Bank);
            registerForm.ShowDialog();
        }



        private void UsersButton_Click(object sender, EventArgs e)
        {
            UserListForm userListForm = new UserListForm(Bank, this);
            Hide();
            userListForm.Show();
        }



        private void DepositsButton_Click(object sender, EventArgs e)
        {
            DepositListForm depositsForm = new DepositListForm(Bank, this);
            Hide();
            depositsForm.Show();
        }
    }
}
