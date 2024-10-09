using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFirst
{
    internal class HelloWorld
    {
        static void Main()
        {
            // Вступительный текст
            Console.Write("Enter the username: ");

            // Входящие переменные
            string username = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Hello world from {username}");

            // Ожидание ввода любой клавиши перед закрытием
            Console.ReadKey();
        }
    }
}
