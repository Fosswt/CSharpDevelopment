using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
                Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
                ordem crescente ou decrescente
             */
            Console.WriteLine("Insira um número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro número: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("São múltiplos.");
            }
            else
            {
                Console.WriteLine("Não são múltiplos entre si.");
            }
            Console.ReadLine();
        }
    }
}
