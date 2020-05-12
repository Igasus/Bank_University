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
    public partial class CreateBankForm : Form
    {
        public CreateBankForm()
        {
            InitializeComponent();
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
    }
}
