using System;
using System.Windows.Forms;
using Bank_Logic;



namespace Bank_University
{
    public partial class ProfileEditForm : Form
    {
        private User _user;



        public ProfileEditForm()
        {
            InitializeComponent();
        }



        public ProfileEditForm(User user, bool newAccountTextBoxEnabled = true) : this()
        {
            _user = user;

            NewAccountTextBox.Enabled = newAccountTextBoxEnabled;
            NewUsernameTextBox.Text = _user.Username;
            NewPasswordTextBox.Text = _user.Password;
            NewNameTextBox.Text = _user.Name;
            NewSurnameTextBox.Text = _user.Surname;
            NewAccountTextBox.Text = String.Format("{0:0.00}", _user.Account);
            NewBirthDateTextBox.Text = _user.BirthDate.ToString();

            UpdateInfo();
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
            }
            catch (Exception exception)
            {
                Program.ShowErrorMessageBox(exception.Message);
            }
        }



        private void DepositButton_Click(object sender, EventArgs e)
        {
            LocalDepositListForm form = new LocalDepositListForm(user: _user);
            form.ShowDialog();
        }

        

        private void NewBirthDateTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] date = NewBirthDateTextBox.Text.Split('.');

                if (date.Length != 3 || date[0].Length != 2 || date[1].Length != 2 || date[2].Length != 4)
                    return;

                int day = Convert.ToInt32(date[0]);
                int month = Convert.ToInt32(date[1]);
                int year = Convert.ToInt32(date[2]);

                Date correctDate = new Date(day, month, year);

                DateTime calendarDate = Convert.ToDateTime($"{correctDate.Day}/{correctDate.Month}/{correctDate.Year}");
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



        public void UpdateInfo()
        {
            OldUsernameTextBox.Text = _user.Username;
            OldPasswordTextBox.Text = _user.Password;
            OldNameTextBox.Text = _user.Name;
            OldSurnameTextBox.Text = _user.Surname;
            OldAccountTextBox.Text = String.Format("{0:0.00}", _user.Account);
            OldBirthDateTextBox.Text = _user.BirthDate.ToString();

            DateButton.Text = Date.CurrentDate.ToString();
        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
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
