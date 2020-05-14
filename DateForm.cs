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
    public partial class DateForm : Form
    {
        public DateForm()
        {
            InitializeComponent();

            UpdateInfo();
        }



        public void UpdateInfo()
        {
            CurrentDateTextBox.Text = Date.CurrentDate.ToString();
        }



        private void NewDateMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                string date = NewDateMonthCalendar.SelectionRange
                                                 .Start
                                                 .ToShortDateString();
                NewDateTextBox.Text = date;
            }
            catch (Exception) { }
        }



        private void NewDateTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] date = NewDateTextBox.Text.Split('.');

                if (date.Length != 3 || date[0].Length != 2 || date[1].Length != 2 || date[2].Length != 4)
                    return;

                int day = Convert.ToInt32(date[0]);
                int month = Convert.ToInt32(date[1]);
                int year = Convert.ToInt32(date[2]);

                Date correctDate = new Date(day, month, year);

                DateTime calendarDate = Convert.ToDateTime($"{correctDate.Day}/{correctDate.Month}/{correctDate.Year}");
                NewDateMonthCalendar.SetDate(calendarDate);
            }
            catch (Exception) { }
        }



        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try {
                string[] date = NewDateTextBox.Text.Split('.');
                Date.CurrentDate.SetDate(Convert.ToInt32(date[0]),
                                        Convert.ToInt32(date[1]),
                                        Convert.ToInt32(date[2]));
            }
            catch (Exception exception)
            {
                Program.ShowErrorMessageBox(exception.Message);
            }
        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void DateTimer_Tick(object sender, EventArgs e)
        {
            UpdateInfo();
        }
    }
}
