using System;
using System.Windows.Forms;
using Bank_Logic;



namespace Bank_University
{
    public partial class BankListForm : Form
    {
        public Bank SelectedBank { get; private set; }



        public BankListForm()
        {
            InitializeComponent();

            SelectedBank = null;

            UpdateInfo();
        }



        private void BankListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Date.StopCurrentDate();
            Program.SaveData();
        }



        public void UpdateBankList()
        {
            BankListBox.Items.Clear();
            for (int i = 0; i < Bank.Banks.Count; i++)
                BankListBox.Items.Insert(i, Bank.Banks[i].Title);
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



        private void OpenBankMenu(Bank bank)
        {
            BankMenuForm bankMenu = new BankMenuForm(SelectedBank);
            Hide();
            bankMenu.Show();
        }



        private void OpenBankButton_Click(object sender, EventArgs e)
        {
            OpenBankMenu(SelectedBank);
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



        private void BankListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SelectedBank == null)
                return;

            OpenBankMenu(SelectedBank);
        }



        public void UpdateInfo()
        {
            UpdateBankList();
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
