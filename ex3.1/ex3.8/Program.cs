using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            Lembrando que, por definição, fatorial de 0 é 1.

             */
            Console.WriteLine("Calculador de fatorial");
            Console.Write("Insira um número: ");
            int num = int.Parse(Console.ReadLine());
            int lt = 1;
            for (int i = 1; i <= num; i++)
            {
                lt = lt * i;
            }
            Console.WriteLine(lt);
            Console.ReadLine();
        }
    }
}
