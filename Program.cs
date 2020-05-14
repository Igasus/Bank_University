using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Logic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Bank_Serialization;



namespace Bank_University
{
    static class Program
    {
        static public BankListForm StartForm;

        static public void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        static private void ClearDirectory(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            foreach (FileInfo file in directoryInfo.GetFiles())
                file.Delete();

            foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
                directory.Delete(true);
        }



        static public void SaveData()
        {
            string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + @"\Saves";
            string datePath = path + @"\date.json";
            string banksPath = path + @"\banks";

            ClearDirectory(path);

            
            using (StreamWriter streamWriter = new StreamWriter(datePath))
            {
                SerializationCurrentDate serializationCurrentDate = new SerializationCurrentDate();
                string dateJson = JsonSerializer.Serialize<SerializationCurrentDate>(serializationCurrentDate);
                streamWriter.Write(dateJson);
            }


            Directory.CreateDirectory(banksPath);
            foreach (Bank bank in Bank.Banks)
                SaveBank(banksPath + @"\" + bank.Title, bank);
        }



        static private void SaveBank(string bankPath, Bank bank)
        {
            Directory.CreateDirectory(bankPath);

            string usersPath = bankPath + @"\Users";
            string depositsPath = bankPath + @"\Deposits";
            string localDepositsPath = bankPath + @"\LocalDeposits";

            SaveElements(usersPath, users: bank.Users);
            SaveElements(depositsPath, deposits: bank.Deposits);

            foreach (Deposit deposit in bank.Deposits)
                SaveElements(localDepositsPath, localDeposits: deposit.LocalDeposits);
        }



        static private void SaveElements(string path,
            List<User> users = null,
            List<Deposit> deposits = null,
            List<LocalDeposit> localDeposits = null)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if (users != null)
                foreach (User user in users)
                    SaveElement(path, user: user);

            else if (deposits != null)
                foreach (Deposit deposit in deposits)
                    SaveElement(path, deposit: deposit);

            else if (localDeposits != null)
                foreach (LocalDeposit localDeposit in localDeposits)
                    SaveElement(path, localDeposit: localDeposit);
        }



        static private void SaveElement(string folderPath,
            User user = null,
            Deposit deposit = null,
            LocalDeposit localDeposit = null)
        {
            string fileName = "unknown.json";

            if (user != null)
                fileName = user.Username + ".json";
            else if (deposit != null)
                fileName = deposit.Title + ".json";
            else if (localDeposit != null)
            {
                int i = 0;
                do
                    fileName = localDeposit.User.Username + "." + localDeposit.Title + $".{i++}.json";
                while (File.Exists(folderPath + @"\" + fileName));
            }

            string filePath = folderPath + @"\" + fileName;

            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                string elementJson = "<Unknown>";

                if (user != null)
                    elementJson = user.Json();
                else if (deposit != null)
                    elementJson = deposit.Json();
                else if (localDeposit != null)
                    elementJson = localDeposit.Json();

                streamWriter.Write(elementJson);
            }
        }



        static public void LoadData()
        {
            string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + @"\Saves";
            

            string datePath = path + @"\date.json";
            if (File.Exists(datePath))
                using (StreamReader streamReader = new StreamReader(datePath))
                {
                    try
                    {
                        string dateJson = streamReader.ReadToEnd();
                        SerializationCurrentDate serializationCurrentDate = SerializationCurrentDate.Deserialize(dateJson);
                        Date.SetCurrentDateData(serializationCurrentDate);
                    }
                    catch (Exception) { }
                }
            

            if (Directory.Exists(path + @"\Banks"))
            {
                string[] bankPathArray = Directory.GetDirectories(path + @"\Banks");
                foreach (string bankPath in bankPathArray)
                {
                    Bank bank = LoadBank(bankPath);
                    Bank.Banks.Add(bank);
                }
            }
        }



        static private Bank LoadBank(string path)
        {
            string bankTitle = path.Substring(path.LastIndexOf('\\') + 1, path.Length - path.LastIndexOf('\\') - 1);

            string usersPath = path + @"\Users";
            string depositsPath = path + @"\Deposits";
            string localDepositsPath = path + @"\LocalDeposits";

            List<SerializationUser> serializationUsers = new List<SerializationUser>();
            List<SerializationDeposit> serializationDeposits = new List<SerializationDeposit>();
            List<SerializationLocalDeposit> serializationLocalDeposits = new List<SerializationLocalDeposit>();


            if (Directory.Exists(usersPath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(usersPath);
                FileInfo[] fileInfos = directoryInfo.GetFiles();

                foreach (FileInfo fileInfo in fileInfos)
                    using (StreamReader streamReader = fileInfo.OpenText())
                    {
                        string userJson = streamReader.ReadToEnd();
                        SerializationUser serializationUser =
                            SerializationUser.Deserialize(userJson);
                        serializationUsers.Add(serializationUser);
                    }
            }


            if (Directory.Exists(depositsPath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(depositsPath);
                FileInfo[] fileInfos = directoryInfo.GetFiles();

                foreach (FileInfo fileInfo in fileInfos)
                    using (StreamReader streamReader = fileInfo.OpenText())
                    {
                        string depositJson = streamReader.ReadToEnd();
                        SerializationDeposit serializationDeposit =
                            SerializationDeposit.Deserialize(depositJson);
                        serializationDeposits.Add(serializationDeposit);
                    }
            }


            if (Directory.Exists(localDepositsPath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(localDepositsPath);
                FileInfo[] fileInfos = directoryInfo.GetFiles();

                foreach (FileInfo fileInfo in fileInfos)
                    using (StreamReader streamReader = fileInfo.OpenText())
                    {
                        string localDepositJson = streamReader.ReadToEnd();
                        SerializationLocalDeposit serializationLocalDeposit =
                            SerializationLocalDeposit.Deserialize(localDepositJson);
                        serializationLocalDeposits.Add(serializationLocalDeposit);
                    }
            }


            Bank bank = Bank.GetObject(bankTitle, serializationUsers, serializationDeposits, serializationLocalDeposits);

            return bank;
        }



        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartForm = new BankListForm();
            Application.Run(StartForm);
        }
    }
}
