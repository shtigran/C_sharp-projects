using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemConsole_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            SystemConsolemethods();


            Console.ReadKey();

        }

        private static void SystemConsolemethods()
        {
            Console.WriteLine("**** System.Console methods ****");
            Console.WriteLine();


            // Задаем задний фон текста
            ConsoleColor prev = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Печатаем с синим фоном ))");
            Console.BackgroundColor = prev;
            Console.WriteLine();
            Console.WriteLine("Теперь печатаем с восстановленным фоном");
            //Выдает звукофой сигнал 
            //Console.Beep();

            //Задаем высоту и ширину консоли
            Console.BufferHeight = 150;
            Console.BufferWidth = 200;
            Console.WriteLine();
            // Показывает включен ли CapsLock
            Console.WriteLine("Включен ли CapsLock: {0}", Console.CapsLock);
            Console.WriteLine();
            // Console.Clear(); удаляет все из консоли
            // Задает размер курсора  
            Console.CursorSize = 50;
            // Показывать или не показывать
            Console.CursorVisible = false;
            // Задает цвет текста
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hi in red");
            //Устанавливает цвета по умолчанию
            Console.ResetColor();
            //Устанавливает заголовок консоли
            Console.Title = "Tigran Shakhbekyan samples";
            //Задаем высоту и ширину консоли увеличивая на юкране
            Console.WindowWidth = 100;
            Console.WindowHeight = 40;

            Console.WindowTop = 1;
            Console.WindowLeft = 1;
        }
    }
}
