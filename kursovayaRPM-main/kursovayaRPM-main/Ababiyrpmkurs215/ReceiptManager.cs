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
        string filePath = @"C:\Users\Kab-35-6\Desktop\kursovayaRPM-main\kursovayaRPM-main\Ababiyrpmkurs215\bin\Debug\receipt.bin";
        public void AddTransaction()
        {
            try
            {
                Console.WriteLine("Выберите валюту для операции:");
                Console.WriteLine("1. Евро");
                Console.WriteLine("2. Рубли");
                Console.WriteLine("3. Доллары");
                Console.Write("Введите номер выбранной валюты: ");
                int currencyChoice = int.Parse(Console.ReadLine());

                string currency = null;
                switch (currencyChoice)
                {
                    case 1:
                        currency = "евро";
                        break;
                    case 2:
                        currency = "рубли";
                        break;
                    case 3:
                        currency = "доллары";
                        break;
                    default:
                        Console.WriteLine("Неправильный выбор валюты.");
                        return;
                }

                Console.WriteLine($"Введите сумму в {currency}:");
                decimal amount = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Введите ваше имя:");
                string name1 = Console.ReadLine();
                Console.WriteLine("Введите вашу фамилию:");
                string name2 = Console.ReadLine();
                Console.Write("Введите имя оператора: ");
                string currentOperator = Console.ReadLine();
                Console.Write("Введите номер телефона: ");
                int phoneNumber = Convert.ToInt32(Console.ReadLine());

                transactions.Add(new Transaction(name1, name2, currentOperator, phoneNumber, amount, currency));

                SaveToFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                AddTransaction();
            }
            finally
            {
                LoadFromFile();
            }
        }
        // ваш существующий код здесь

        public void EditTransaction()
        {
            Console.WriteLine("Введите номер чека, который вы хотите отредактировать:");
            int receiptNumber = int.Parse(Console.ReadLine());

            // Проверяем, существует ли чек с указанным номером
            if (receiptNumber < 1 || receiptNumber > transactions.Count)
            {
                Console.WriteLine("Чек с таким номером не найден.");
                return;
            }

             // Нумерация чеков начинается с 1, а не с 0

            Console.WriteLine("Что вы хотите отредактировать?");
            Console.WriteLine("1. Сумма");
            Console.WriteLine("2. Имя оператора");
            Console.WriteLine("3. Номер телефона");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите новую сумму:");
                    decimal newAmount = decimal.Parse(Console.ReadLine());
                    transactions[receiptNumber - 1].Amount = newAmount;
                    Console.WriteLine("Сумма чека успешно изменена.");
                    break;
                case 2:
                    Console.WriteLine("Введите новое имя оператора:");
                    string newOperatorName = Console.ReadLine();
                    transactions[receiptNumber - 1].OperatorName = newOperatorName;
                    Console.WriteLine("Имя оператора успешно изменено.");
                    break;
                case 3:
                    Console.WriteLine("Введите новый номер телефона:");
                    int newPhoneNumber = int.Parse(Console.ReadLine());
                    transactions[receiptNumber - 1].PhoneNumber = newPhoneNumber;
                    Console.WriteLine("Номер телефона успешно изменен.");
                    break;
                default:
                    Console.WriteLine("Неправильный выбор.");
                    break;
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
