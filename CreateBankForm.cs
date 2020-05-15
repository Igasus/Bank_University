using System;
using System.Windows.Forms;
using Bank_Logic;



namespace Bank_University
{
    public partial class CreateBankForm : Form
    {
        public CreateBankForm()
        {
            InitializeComponent();

            UpdateInfo();
        }



        private void NewBankSubmitButon_Click(object sender, EventArgs e)
        {
            string bankTitle = TitleTextBox.Text;
            try
            {
                Bank.CreateBank(bankTitle);
                Close();
            }
            catch (Exception exception)
            {
                Program.ShowErrorMessageBox(exception.Message);
            }
        }



        private void CreateBankCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            string titleTextBoxText = TitleTextBox.Text;
            if (titleTextBoxText == "")
                SubmitButon.Enabled = false;
            else
                SubmitButon.Enabled = true;
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
