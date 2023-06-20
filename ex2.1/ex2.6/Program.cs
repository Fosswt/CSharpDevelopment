using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
            seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em 
            nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
             */
            Console.WriteLine("Insira um número de 0 até 100: ");
            double choice = double.Parse(Console.ReadLine());
            if (choice <= 25)
            {
                Console.WriteLine("Esse valor se encontra no intervalo [0,25]. ");
            }
            else if(choice <= 50)
            {
                Console.WriteLine("Esse valor se encontra no intervalo (25,50]. ");
            }
            else if (choice <= 75)
            {
                Console.WriteLine("Esse valor se encontra no intervalo (50,75]. ");
            }
            else if (choice <= 100)
            {
                Console.WriteLine("Esse valor se encontra no intervalo (75,100]. ");
            }
            else
            {
                Console.WriteLine("Fora de intervalo.");
            }
            Console.ReadLine();
        }
    }
}
