using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Ababiyrpmkurs215
{
    class ReceiptManager
    {
        private List<Transaction> transactions = new List<Transaction>();
        string filePath = @"C:\Users\Kab-35-6\Desktop\kursovayaRPM-main\Ababiyrpmkurs215\bin\Debug\receipt.bin";
        public void AddTransaction()
        {
            try
            {
                
                Console.Write("Введите имя оператора: ");
                string currentOperator = Console.ReadLine();
                Console.Write("Введите номер телефона: ");
                int phoneNumber =Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите сумму наличных: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                transactions.Add(new Transaction(currentOperator, phoneNumber, amount));
                

                SaveToFile();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);AddTransaction();
            }
            finally { 
            LoadFromFile();
                }
           
        }

        public void Delete()
        {
            LoadFromFile();
            transactions.Clear();
            SaveToFile();
        }
        public void PrintReceipts()
        {
            LoadFromFile();
            foreach (var transaction in transactions)
            {
                Console.WriteLine(transaction);
            }
        }

        public void SaveToFile()
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, transactions);
            }
        }

        public void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    transactions = (List<Transaction>)formatter.Deserialize(fs);
                }
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }
        }
    }
}
