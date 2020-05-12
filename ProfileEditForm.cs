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
    public partial class ProfileEditForm : Form
    {
        private User _user;
        private Form _previousForm;



        public ProfileEditForm()
        {
            InitializeComponent();
        }



        public ProfileEditForm(User user, Form previousForm = null) : this()
        {
            _user = user;
            _previousForm = previousForm;

            OldUsernameTextBox.Text = _user.Username;
            OldPasswordTextBox.Text = _user.Password;
            OldNameTextBox.Text = _user.Name;
            OldSurnameTextBox.Text = _user.Surname;
            OldAccountTextBox.Text = String.Format("{0:0.00}", _user.Account);
            OldBirthDateTextBox.Text = _user.BirthDate.ToString();

            NewUsernameTextBox.Text = _user.Username;
            NewPasswordTextBox.Text = _user.Password;
            NewNameTextBox.Text = _user.Name;
            NewSurnameTextBox.Text = _user.Surname;
            NewAccountTextBox.Text = String.Format("{0:0.00}", _user.Account);
            NewBirthDateTextBox.Text = _user.BirthDate.ToString();
        }



        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try {
                _user.Username = NewUsernameTextBox.Text;
                _user.Password = NewPasswordTextBox.Text;
                _user.Name = NewNameTextBox.Text;
                _user.Surname = NewSurnameTextBox.Text;
                _user.Account = Convert.ToDouble(NewAccountTextBox.Text);
                
                string[] date = NewBirthDateTextBox.Text.Split('.');
                _user.BirthDate.SetDate(Convert.ToInt32(date[0]),
                                        Convert.ToInt32(date[1]), 
                                        Convert.ToInt32(date[2]));

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



        private void DepositButton_Click(object sender, EventArgs e)
        {

        }

        

        private void NewBirthDateTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] date = NewBirthDateTextBox.Text.Split('.');
                if (date.Length != 3)
                    return;

                int day = Convert.ToInt32(date[0]);
                int month = Convert.ToInt32(date[1]);
                int year = Convert.ToInt32(date[2]);

                DateTime calendarDate = Convert.ToDateTime($"{day}/{month}/{year}");
                BirthDateCalendar.SetDate(calendarDate);
            }
            catch (Exception) { }
        }



        private void BirthDateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                string date = BirthDateCalendar.SelectionRange
                                                 .Start
                                                 .ToShortDateString();
                NewBirthDateTextBox.Text = date;
            }
            catch (Exception) { }
        }



        private void ProfileEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ((UserListForm) _previousForm).UpdateInfo();
                return;
            }
            catch (Exception) { }
        }
    }
}
