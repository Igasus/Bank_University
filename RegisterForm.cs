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
    public partial class RegisterForm : Form
    {
        private Form _previousForm;
        public Bank Bank { get; private set; }
        public string Username { get => UsernameTextBox.Text; }
        public string Password { get => PasswordTextBox.Text; }
        



        public RegisterForm()
        {
            InitializeComponent();
        }



        public RegisterForm(Bank bank, Form previousForm = null): this()
        {
            _previousForm = previousForm;
            Bank = bank;
        }



        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ((UserListForm)_previousForm).UpdateUserGrid();
            }
            catch (Exception) { }
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
    }
}
