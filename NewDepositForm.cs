using System;
using System.Windows.Forms;
using Bank_Logic;



namespace Bank_University
{
    public partial class NewDepositForm : Form
    {
        public Bank Bank { get; private set; }




        public NewDepositForm()
        {
            InitializeComponent();
        }



        public NewDepositForm(Bank bank) : this()
        {
            Bank = bank;

            UpdateInfo();
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



        public void UpdateInfo()
        {
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
    }
}
