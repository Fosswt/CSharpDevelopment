using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool s = a > 9;
            Console.WriteLine(s);
            bool w = !(a != 10);
            Console.WriteLine(w);
            Console.ReadLine();
        }
    }
}
