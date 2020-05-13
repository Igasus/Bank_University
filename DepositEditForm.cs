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
        private Form _previousForm;
        private Deposit _deposit;



        public DepositEditForm()
        {
            InitializeComponent();
        }



        public DepositEditForm(Deposit deposit, Form previousForm) : this()
        {
            _previousForm = previousForm;
            _deposit = deposit;

            UpdateInfo();
        }



        private void DepositEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ((DepositListForm)_previousForm).UpdateInfo();
            }
            catch (Exception) { }
        }



        private void LocalDepositListButton_Click(object sender, EventArgs e)
        {
            LocalDepositListForm form = new LocalDepositListForm(_deposit.LocalDeposits, this, deposit: _deposit);
            form.ShowDialog();
        }



        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                _deposit.Title = NewTitleTextBox.Text;
                _deposit.AnnualRate = Convert.ToDouble(NewAnnualRateTextBox.Text) / 100;
                _deposit.Duration = Convert.ToInt32(NewDurationTextBox.Text);

                Close();
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

            NewTitleTextBox.Text = _deposit.Title;
            NewAnnualRateTextBox.Text = String.Format("{0:0.00}", _deposit.AnnualRate * 100);
            NewDurationTextBox.Text = _deposit.Duration.ToString();
        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
