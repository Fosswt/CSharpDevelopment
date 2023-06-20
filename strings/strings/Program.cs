using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string frase = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string allIn = Console.ReadLine();
            string[] v = allIn.Split(' ');

            Console.WriteLine(frase);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(v[0]);
            Console.WriteLine(v[1]);
            Console.WriteLine(v[2]);

            Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}
