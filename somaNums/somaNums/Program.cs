using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números você irá digitar?");
            int nums = int.Parse(Console.ReadLine());
            int soma = 0;
            for (var i = 1; i < nums + 1; i++)
            {
                Console.WriteLine($"Numero {i}: " );
                int num = int.Parse(Console.ReadLine());
                soma += num;
            }
            Console.WriteLine("Soma total dos números: "+soma);
            Console.ReadLine();
        }
    }
}
