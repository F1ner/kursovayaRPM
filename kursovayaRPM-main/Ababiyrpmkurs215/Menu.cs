using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiyrpmkurs215
{
    internal class Menu
    {
        public void Menu1()
        {
            ReceiptManager receiptManager = new ReceiptManager();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("1. Введите данные для написания чека:");
                Console.WriteLine("2. Распечатать чек(и):");
                Console.WriteLine("3.Удалить информацию о сохраненных чеках:");
                Console.WriteLine("4.Выход:");
                Console.Write("Выберете нужное действие: ");
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        receiptManager.AddTransaction();
                        break;
                    case 2:
                        receiptManager.PrintReceipts(); Console.ReadLine();
                        break;
                    case 3:
                        receiptManager.Delete(); Console.ReadLine();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неправильный выбор, повторите попытку.");
                        break;
                }
            }


        }
    }
}
