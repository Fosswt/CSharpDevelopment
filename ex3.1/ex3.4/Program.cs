using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o 
                X, se for o caso.
             */
            Console.WriteLine("Mostrando os números ímpares!");
            Console.Write("Informe um número entre 1 e 1000: ");
            int num = int.Parse(Console.ReadLine());

                for (var i = 1; i <= num; i+=2)
                {
                    Console.WriteLine("ÍMPAR: "+i);
                }
            Console.ReadLine();

        }
    }
}
