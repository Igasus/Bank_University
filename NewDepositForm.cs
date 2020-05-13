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
    public partial class NewDepositForm : Form
    {
        private Form _previousForm;
        public Bank Bank { get; private set; }




        public NewDepositForm()
        {
            InitializeComponent();
        }



        public NewDepositForm(Bank bank, Form previousForm) : this()
        {
            _previousForm = previousForm;
            Bank = bank;
        }



        private void NewDepositForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ((DepositListForm)_previousForm).UpdateInfo();
            }
            catch (Exception) { }
        }



        private void UpdateSubmitButton()
        {
            if (TitleTextBox.Text == "" || AnnualRateTextBox.Text == "" || DurationTextBox.Text == "")
                SubmitButton.Enabled = false;
            else
                SubmitButton.Enabled = true;
        }



        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSubmitButton();
        }



        private void AnnualRateTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSubmitButton();
        }



        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSubmitButton();
        }



        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string title = TitleTextBox.Text;
                double annualRate = Convert.ToDouble(AnnualRateTextBox.Text) / 100;
                int duration = Convert.ToInt32(DurationTextBox.Text);
                Bank.CreateDeposit(Bank, title, annualRate, duration);
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
