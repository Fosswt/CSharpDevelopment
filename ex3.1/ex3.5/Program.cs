using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)
             */
            Console.Write("Informe a quantidade de valores de entrada: ");
            int num = int.Parse(Console.ReadLine());

            int In = 0;
            int Out = 0;
            for (var i = 0; i < num; i++)
            {
                Console.Write("Insira um número: ");
                int read = int.Parse(Console.ReadLine());
                if (read >= 10 && read <= 20)
                {
                    In++;
                }
                else
                {
                    Out++;
                }
            }
            Console.WriteLine($"In: {In}");
            Console.WriteLine($"Out: {Out}");
            Console.ReadLine();
        }
    }
}
