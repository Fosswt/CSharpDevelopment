using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo 
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel"
             */
            Console.Write("Insira o número de leituras: ");
            int leituras = int.Parse(Console.ReadLine());
            for (var i = 0; i < leituras; i++)
            {
                Console.Write("Insira dois números na mesma linha: ");
                string[] allIn = Console.ReadLine().Split(' ');
                double num1 = double.Parse(allIn[0]);
                double num2 = double.Parse(allIn[1]);
                if (num2 == 0)
                {
                    Console.WriteLine("Divisão impossível.");
                }
                else
                {
                    Console.WriteLine($"{num1} / {num2} = {num1/num2}");
                }

            }
            Console.ReadLine();
        }
    }
}
