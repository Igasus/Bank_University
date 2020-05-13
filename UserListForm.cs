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
                    String.Format("{0:0.00}", user.Account),
                    user.BirthDate.ToString(),
                    user.Deposits.Count.ToString()
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
            DeleteButton.Enabled = false;
            string toFind = SearchTextBox.Text;
            if (toFind != "")
            {
                List<User> result = Bank.SearchUsers(toFind);
                SetUserGrid(result);
            }
            else
                UpdateUserGrid();
        }



        private void OpenEditForm(User user)
        {
            ProfileEditForm profileForm = new ProfileEditForm(user, this);
            profileForm.ShowDialog();
        }



        private void UserGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = UserGridView.CurrentRow;
            
            if (currentRow == null || currentRow.Index < 0 && currentRow.Index >= _currentUsers.Count)
                return;
            User selectedUser = _currentUsers[currentRow.Index];

            OpenEditForm(selectedUser);
        }



        public void UpdateInfo()
        {
            SearchTextBox.Text = "";
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            UpdateUserGrid();
        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = UserGridView.CurrentRow.Index;
            User user = _currentUsers[rowIndex];
            Bank.DeleteUser(user);
            UpdateInfo();
        }



        private void UserGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow currentRow = UserGridView.CurrentRow;

            if (currentRow == null || currentRow.Index < 0 && currentRow.Index >= _currentUsers.Count)
            {
                DeleteButton.Enabled = false;
                EditButton.Enabled = false;
            }
            else
            {
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;
            }
        }



        private void EditButton_Click(object sender, EventArgs e)
        {
            int rowIndex = UserGridView.CurrentRow.Index;
            User selectedUser = _currentUsers[rowIndex];

            OpenEditForm(selectedUser);
        }
    }
}
