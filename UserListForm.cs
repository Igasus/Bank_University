using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Bank_Logic;



namespace Bank_University
{
    public partial class UserListForm : Form
    {
        private List<User> _currentUsers;
        public Bank Bank { get; private set; }



        public UserListForm() => InitializeComponent();



        public UserListForm(Bank bank) : this()
        {
            Bank = bank;
            _currentUsers = new List<User>();
            BankTitleLabel.Text = Bank.Title + " users";

            ResetInfo();
        }



        private bool IsGridItemList(List<User> users)
        {
            if (_currentUsers.Count != users.Count)
                return false;

            for (int i = 0; i < users.Count; i++)
                if (!users[i].Equals(_currentUsers[i]))
                    return false;
            return true;
        }



        public void SetUserGrid(List<User> users)
        {
            if (IsGridItemList(users))
                return;
            
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
            _currentUsers = new List<User>(users);
        }



        public void UpdateUserGrid()
        {
            string toFind = SearchTextBox.Text;
            if (toFind != "")
            {
                List<User> result = Bank.SearchUsers(toFind);
                SetUserGrid(result);
            }
            else
                SetUserGrid(Bank.Users);
        }



        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(Bank);
            registerForm.ShowDialog();
        }



        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DeleteButton.Enabled = false;
        }



        private void OpenEditForm(User user)
        {
            ProfileEditForm profileForm = new ProfileEditForm(user);
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



        public void ResetInfo()
        {
            SearchTextBox.Text = "";
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
            UpdateUserGrid();
        }



        public void UpdateInfo()
        {
            UpdateUserGrid();

            DateButton.Text = Date.CurrentDate.ToString();
        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = UserGridView.CurrentRow.Index;
            User user = _currentUsers[rowIndex];
            Bank.DeleteUser(user);
            ResetInfo();
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



        private void DateButton_Click(object sender, EventArgs e)
        {
            DateForm form = new DateForm();
            form.Show();
        }



        private void DateTimer_Tick(object sender, EventArgs e)
        {
            UpdateInfo();
        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
