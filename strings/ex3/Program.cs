using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
                de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
             */
            Console.WriteLine("Esse programa lê quatro valores inteiros e depois mostra a diferença do produto de A e B pelo produto de C e D!");
            Console.WriteLine("(A * B) - (C * D)");
            Console.WriteLine("Informe o número A: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número B: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número C: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número D: ");
            int num4 = int.Parse(Console.ReadLine());

            int produto = (num1 * num2) - (num3 * num4);

            Console.WriteLine("(A * B) - (C * D)");
            Console.WriteLine($"({num1} * {num2}) - ({num3} * {num4})");
            Console.WriteLine("Resultado = "+produto);
            Console.ReadLine();

        }
    }
}
