using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
             */
            int duracaoTotal;
            Console.WriteLine("Insira a hora inicial do jogo: ");
            int hrInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a hora final do jogo: ");
            int hrFinal = int.Parse(Console.ReadLine());
            if (hrInicial == hrFinal)
            {
                duracaoTotal = 24;
                Console.WriteLine($"O JOGO DUROU {duracaoTotal} HORAS");
            }
            else if (hrInicial < hrFinal)
            {
                duracaoTotal = hrFinal - hrInicial;
                Console.WriteLine($"O JOGO DUROU {duracaoTotal} HORAS");
            }
            else
            {
                duracaoTotal = 24 - (hrInicial - hrFinal) ;
                Console.WriteLine($"O JOGO DUROU {duracaoTotal} HORAS");
            }
            Console.ReadLine();

        }
    }
}
