using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
            seguir, calcule e mostre o valor da conta a pagar
             */
            

            Console.WriteLine("Insira o código do produto e a quantidade (na mesma linha)");
            string[] allIn = Console.ReadLine().Split(' ');
            int codigo = int.Parse(allIn[0]);
            int qtd = int.Parse(allIn[1]);
            double total;
            if (codigo == 1)
            {
                total = qtd * 4.0;
                Console.WriteLine($"Total : R${total}");
            }
            else if (codigo == 2)
            {
                total = qtd * 4.5;
                Console.WriteLine($"Total : R${total}");
            }
            else if (codigo == 3)
            {
                total = qtd * 5.0;
                Console.WriteLine($"Total : R${total}");
            }
            else if (codigo == 4)
            {
                total = qtd * 2.0;
                Console.WriteLine($"Total : R${total}");
            }
            else if (codigo == 5)
            {
                total = qtd * 1.5;
                Console.WriteLine($"Total : R${total}");
            }
            else
            {
                Console.WriteLine("nn entendi nao mano.");
            }
            
            Console.ReadLine();
        }
    }
}
