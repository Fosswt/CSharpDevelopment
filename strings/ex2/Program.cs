using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
                casas decimais conforme exemplos.
                Fórmula da área: area = π . raio2
                Considere o valor de π = 3.14159             
             */
            float pi = 3.14159F;
            Console.WriteLine("Programa para ler o raio de um círculo");
            Console.WriteLine("Insira o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());
            double area = Math.Pow(raio, 2) * pi;
            Console.WriteLine($"A Área de um círculo com {raio} de raio é {area}!");
            Console.ReadLine();
        }
    }
}
