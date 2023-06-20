using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
             */
            double x;
            double y;
            Console.WriteLine("Sistema identificador de coordenadas X e Y");
            Console.Write("Insira as coordenadas X e Y na mesma linha: ");
            string[] all = Console.ReadLine().Split(' ');
            x = double.Parse(all[0]);
            y = double.Parse(all[1]);
            while (x != 0 && y != 0)
            {
                Console.Write("Insira as coordenadas X e Y na mesma linha: ");
                try
                {
                    string[] all2 = Console.ReadLine().Split(' ');
                    x = double.Parse(all2[0]);
                    y = double.Parse(all2[1]);
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("Quadrante 1");
                    }
                    else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("Quadrante 2");
                    }
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("Quadrante 3");
                    }
                    else if (x > 0 && y < 0)
                    {
                        Console.WriteLine("Quadrante 4");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("programa deu pau menor");
                    
                }
            }
            Console.WriteLine("Programa encerrado!");
            Console.ReadLine();


        }
    }
}
