using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Logic;



namespace Bank_University
{
    static class Program
    {
        static public BankListForm StartForm;

        static public void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Date.CurrentDate.SetDate(1, 1, 2020);
            Bank bank = new Bank("simple");
            bank.CreateDeposit(bank, "someDeposit", 0.5, 1);
            bank.Register("Igasus", "1122");
            bank.Users[0].Account = 1000;

            Bank.Banks.Add(bank);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartForm = new BankListForm();
            Application.Run(StartForm);
        }
    }
}
