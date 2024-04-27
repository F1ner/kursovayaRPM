using System;
using System.Collections.Generic;
using System.IO;
namespace KursovayaAbabiy215
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentSystem paymentSystem = new PaymentSystem();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Выбор оператора");
                Console.WriteLine("2. Ввод номера телефона");
                Console.WriteLine("3. Прием наличных");
                Console.WriteLine("4. Печать чека");
                Console.WriteLine("5. Выход");

                Console.Write("Выберите действие: ");
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        paymentSystem.SelectOperator();
                        break;
                    case 2:
                        paymentSystem.EnterPhoneNumber();
                        break;
                    case 3:
                        paymentSystem.ReceiveCash();
                        break;
                    case 4:
                        paymentSystem.PrintReceipt();
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Выход из программы.");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;

                        
                }
            }
        }
    }
}