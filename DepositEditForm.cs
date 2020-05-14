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
    public partial class DepositEditForm : Form
    {
        private Deposit _deposit;



        public DepositEditForm()
        {
            InitializeComponent();
        }



        public DepositEditForm(Deposit deposit) : this()
        {
            _deposit = deposit;

            NewTitleTextBox.Text = _deposit.Title;
            NewAnnualRateTextBox.Text = String.Format("{0:0.00}", _deposit.AnnualRate * 100);
            NewDurationTextBox.Text = _deposit.Duration.ToString();

            UpdateInfo();
        }



        private void LocalDepositListButton_Click(object sender, EventArgs e)
        {
            LocalDepositListForm form = new LocalDepositListForm(deposit: _deposit);
            form.ShowDialog();
        }



        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                _deposit.Title = NewTitleTextBox.Text;
                _deposit.AnnualRate = Convert.ToDouble(NewAnnualRateTextBox.Text) / 100;
                _deposit.Duration = Convert.ToInt32(NewDurationTextBox.Text);
            }
            catch (Exception exception)
            {
                Program.ShowErrorMessageBox(exception.Message);
            }
        }



        public void UpdateInfo()
        {
            OldTitleTextBox.Text = _deposit.Title;
            OldAnnualRateTextBox.Text = String.Format("{0:0.00}", _deposit.AnnualRate * 100);
            OldDurationTextBox.Text = _deposit.Duration.ToString();

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



        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
