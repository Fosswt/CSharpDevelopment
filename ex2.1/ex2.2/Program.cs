using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar
             */
            Console.WriteLine("Insira um número inteiro e o programa dirá se ele é par ou ímpar! ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Esse número é par.");
            }
            else
            {
                Console.WriteLine("Esse número é ímpar.");
            }
            Console.ReadLine();
        }
    }
}
