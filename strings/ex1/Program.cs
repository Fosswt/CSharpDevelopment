using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
            //mensagem explicativa, conforme exemplos.
            Console.WriteLine("Insira um número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma entre {num} e {num2} é {num+num2}");
            Console.ReadLine();
        }
    }
}
