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
    public partial class ChangeBankTitleForm : Form
    {
        public Bank Bank { get; private set; }



        public ChangeBankTitleForm()
        {
            InitializeComponent();
        }



        public ChangeBankTitleForm(Bank bank): this()
        {
            Bank = bank;

            UpdateInfo();
        }



        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            string titleTextBoxText = TitleTextBox.Text;
            if (titleTextBoxText == "")
                SubmitButon.Enabled = false;
            else
                SubmitButon.Enabled = true;
        }



        private void SubmitButon_Click(object sender, EventArgs e)
        {
            try
            {
                Bank.Title = TitleTextBox.Text;
                Program.StartForm.UpdateBankList();
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
            PreviousTitleTextBox.Text = Bank.Title;
            DateButton.Text = Date.CurrentDate.ToString();
        }



        private void DateTime_Tick(object sender, EventArgs e)
        {
            UpdateInfo();
        }



        private void DateButton_Click(object sender, EventArgs e)
        {
            DateForm form = new DateForm();
            form.Show();
        }
    }
}
