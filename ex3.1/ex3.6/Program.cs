using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes 
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem 
            peso 5 
             */
            Console.Write("Insira o número de casos de teste que deseja testar: ");
            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                Console.WriteLine("insira os 3 valores na (mesma linha)");
                string[] allIn = Console.ReadLine().Split(' ');
                double v1 = double.Parse(allIn[0]);
                double v2 = double.Parse(allIn[1]);
                double v3 = double.Parse(allIn[2]);
                double mediaPonderada = (v1 * 0.2) + (v2 * 0.3) + (v3 * 0.5);
                Console.WriteLine(mediaPonderada.ToString("F1"));
            }
            Console.ReadLine();
        }
    }
}
