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
    public partial class BankListForm : Form
    {
        public Bank SelectedBank { get; private set; }



        public BankListForm()
        {
            SelectedBank = null;
            InitializeComponent();
        }



        private void BankListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Date.StopCurrentDate();
        }



        public void UpdateBankList()
        {
            BankListBox.Items.Clear();
            for (int i = 0; i < Bank.Banks.Count; i++)
                BankListBox.Items.Insert(i, Bank.Banks[i]);
        }



        private void UpdateButtons()
        {
            int selectedIndex = BankListBox.SelectedIndex;
            
            if (selectedIndex >= 0)
            {
                SelectedBank = Bank.Banks[selectedIndex];
                OpenBankButton.Enabled = true;
                ChangeBankTitleButton.Enabled = true;
                DeleteBankButton.Enabled = true;
            }
            else
            {
                SelectedBank = null;
                OpenBankButton.Enabled = false;
                ChangeBankTitleButton.Enabled = false;
                DeleteBankButton.Enabled = false;
            }
        }



        private void BankListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }



        private void OpenBankButton_Click(object sender, EventArgs e)
        {
            BankMenuForm bankMenu = new BankMenuForm(SelectedBank, this);
            Hide();
            bankMenu.Show();
        }



        private void CreateBankButton_Click(object sender, EventArgs e)
        {
            CreateBankForm createForm = new CreateBankForm();
            createForm.ShowDialog();
        }



        private void ChangeBankTitleButton_Click(object sender, EventArgs e)
        {
            ChangeBankTitleForm changeTitleForm = new ChangeBankTitleForm(SelectedBank);
            changeTitleForm.ShowDialog();
        }



        private void DeleteBankButton_Click(object sender, EventArgs e)
        {
            Bank.Banks.Remove(SelectedBank);
            Program.StartForm.UpdateBankList();
            UpdateButtons();
        }
    }
}
