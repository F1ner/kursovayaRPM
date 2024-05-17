using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiyrpmkurs215
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Console.ForegroundColor = ConsoleColor.Black; // Устанавливаем цвет текста
            Console.BackgroundColor = ConsoleColor.White; // Устанавливаем цвет фона
            // Устанавливаем размер окна
            Console.WindowWidth = Console.LargestWindowWidth - 10; // больше символов по горизонтали
            Console.WindowHeight = Console.LargestWindowHeight - 5; // больше строк по вертикали

           // Храним заранее заданный логин и пароль
        string correctUsername = "admin";
        string correctPassword = "password";
        m1:
        // Запрашиваем у пользователя логин и пароль
        Console.WriteLine("Введите логин:");
        string username = Console.ReadLine();

        Console.WriteLine("Введите пароль:");
        string password = Console.ReadLine();
        
        // Проверяем введенные данные
        if (username == correctUsername && password == correctPassword)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вход выполнен успешно!");
             Console.ForegroundColor = ConsoleColor.Black; // Устанавливаем цвет текста
            Console.BackgroundColor = ConsoleColor.White; // Устанавливаем цвет фона
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неверный логин или пароль. Попробуйте снова.Чтобы выйти напишите ");
             Console.ForegroundColor = ConsoleColor.Black; // Устанавливаем цвет текста
            Console.BackgroundColor = ConsoleColor.White; // Устанавливаем цвет фона
            Console.Write("Хотите продолжить?");
            string answer=Console.ReadLine();
            if(answer=="нет")
            {
                  return;  
            }
            else if(answer=="да")
            {
                    goto m1;
            }
            else
            {
                    Console.WriteLine("Введено неверное значение.Выход из программы");
                    return;
            }
        }
         Console.ForegroundColor = ConsoleColor.Black; // Устанавливаем цвет текста
            Console.BackgroundColor = ConsoleColor.White; // Устанавливаем цвет фона
       //Console.ReadLine(); // Ждем, пока пользователь не нажмет Enter

            Menu mu = new Menu();
            mu.Menu1();
        }
    }
}
