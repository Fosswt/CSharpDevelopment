using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas 
                de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o 
                ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
             */
            Console.WriteLine("Informe dois valores (x e y) e o programa dirá em qual quadrante ele se encaixa.");
            string[] allIn = Console.ReadLine().Split(' ');
            double x = double.Parse(allIn[0]);
            double y = double.Parse(allIn[1]);
            if (x == 0.0 && y == 0)
            {
                Console.WriteLine("Meio do quadrante! ambos os valores são nulos.");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }

            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
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
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Quadrante 1");
            }

        }
    }
}
