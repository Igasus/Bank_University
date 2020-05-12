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
    public partial class UserListForm : Form
    {
        private Form _previousForm;
        private bool _backAction;
        private List<User> _currentUsers;
        public Bank Bank { get; private set; }



        public UserListForm() => InitializeComponent();



        public UserListForm(Bank bank, Form previousForm) : this()
        {
            Bank = bank;
            _backAction = false;
            _previousForm = previousForm;
            _currentUsers = Bank.Users;
            BankTitleLabel.Text = Bank.Title + " users";
        }



        public void SetUserGrid(List<User> users)
        {
            UserGridView.Rows.Clear();
            users.ForEach(user => {
                string[] row = new string[]
                {
                    user.Username,
                    user.Password,
                    user.Name,
                    user.Surname,
                    user.Account.ToString(),
                    user.BirthDate.ToString(),
                    user.Deposits.Length.ToString()
                };
                UserGridView.Rows.Add(row);
            });
            _currentUsers = users;
        }



        public void UpdateUserGrid() => SetUserGrid(Bank.Users);

        private void UserListForm_Load(object sender, EventArgs e) => UpdateUserGrid();

        private void UserListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_backAction)
                _previousForm.Show();
            else
                Program.StartForm.Close();
        }



        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(Bank, this);
            registerForm.ShowDialog();
        }



        private void BackButton_Click(object sender, EventArgs e)
        {
            _backAction = true;
            Close();
        }



        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string toFind = SearchTextBox.Text;
            if (toFind != "")
            {
                List<User> result = Bank.Search(toFind);
                SetUserGrid(result);
            }
            else
                UpdateUserGrid();
        }



        private void UserGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = UserGridView.CurrentRow.Index;
            User selectedUser = _currentUsers[rowIndex];
            
            ProfileEditForm profileForm = new ProfileEditForm(selectedUser, this);
            profileForm.ShowDialog();
        }



        public void UpdateInfo()
        {
            SearchTextBox.Text = "";
            UpdateUserGrid();
        }
    }
}
