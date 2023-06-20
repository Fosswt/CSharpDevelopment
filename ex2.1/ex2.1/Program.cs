using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            Console.WriteLine("Informe um número inteiro e o programa dirá se ele é negativo ou positivo. ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Esse número é positivo.");
            }
            else if (num < 0)
            {
                Console.WriteLine("Esse número é negativo.");
            }
            else
            {
                Console.WriteLine("Esse número é igual a zero.");
            }
            Console.ReadLine();
        }
    }
}
