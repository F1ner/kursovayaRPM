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
            decimal usdToRub = 90;
            decimal eurToRub = 97;

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("1. Введите данные для написания чека:");
                Console.WriteLine("2. Распечатать чек(и):");
                Console.WriteLine("3.Удалить информацию о сохраненных чеках:");
                Console.WriteLine("4. Узнать текущий курс доллара к рублю");
                Console.WriteLine("5. Узнать текущий курс евро к рублю");
                Console.WriteLine("6.Узнать текущее время:");
                Console.WriteLine("7.Отредактироватьопределнный чек:");
                Console.WriteLine("8.Выход:");
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
                        Console.WriteLine($"Текущий курс доллара к рублю: 1:{usdToRub}");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine($"Текущий курс евро к рублю: 1:{eurToRub}");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine($"Текущее время: {DateTime.Now}");
                        Console.ReadLine();
                        break;
                    case 7:
                        receiptManager.EditTransaction();
                        break;

                    case 8:
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
