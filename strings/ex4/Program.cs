using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
            decimais.
             */
            Console.WriteLine("Informe o número do funcionário: ");
            int numFunc = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de horas trabalhadas pelo funcionário "+numFunc);
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o rendimento desse funcionário por hora");
            float recebeQnt = float.Parse(Console.ReadLine());
            float salario = recebeQnt * horasTrabalhadas;
            Console.WriteLine("Número do funcionário: "+numFunc);
            Console.WriteLine("Salário do funcionário: "+salario);
            Console.ReadLine();
        }
    }
}
