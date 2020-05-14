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
    public partial class ProfileForm : Form
    {
        private User _user;



        public ProfileForm()
        {
            InitializeComponent();
        }



        public ProfileForm(User user) : this()
        {
            _user = user;

            UpdateInfo();
        }



        public void UpdateInfo()
        {
            UsernameTextBox.Text = _user.Username;
            NameTextBox.Text = _user.Name;
            SurnameTextBox.Text = _user.Surname;
            AccountTextBox.Text = String.Format("{0:0.00}", _user.Account);

            DateButton.Text = Date.CurrentDate.ToString();
        }





        private void OpenDepositListButton_Click(object sender, EventArgs e)
        {
            LocalDepositListForm form = new LocalDepositListForm(user: _user);
            form.ShowDialog();
        }



        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            ProfileEditForm form = new ProfileEditForm(_user);
            form.ShowDialog();
        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void AccountActionsButton_Click(object sender, EventArgs e)
        {
            UserAccountActionsForm form = new UserAccountActionsForm(_user);
            form.ShowDialog();
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
