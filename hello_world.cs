using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFirst
{
    internal class hello_world
    {
        static void Main(string[] aRgS)
        {
            Console.Write("Enter the username: ");
            String username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello world from {username}");
            Console.ReadKey();
        }
    }
}
