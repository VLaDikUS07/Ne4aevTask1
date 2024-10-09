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
            Console.Write("Enter the username: ");
            string username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello world from {username}");
            Console.ReadKey();
        }
    }
}
