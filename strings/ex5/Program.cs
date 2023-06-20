using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago
             */
            Console.WriteLine("Informe o código da peça, o número de peças e o valor unitário de cada uma (na mesma linha)");
            string allIn = Console.ReadLine();
            string[] infos = allIn.Split(' ');
            int code1 = int.Parse(infos[0]);
            int num1 = int.Parse(infos[1]);
            float preco1 = float.Parse(infos[2]);
   
            Console.WriteLine("Informe o código da peça, o número de peças e o valor unitário de cada uma (na mesma linha)");
            string allIn2 = Console.ReadLine();
            string[] infos2 = allIn2.Split(' ');
            int code2 = int.Parse(infos2[0]);
            int num2 = int.Parse(infos2[1]);
            float preco2 = float.Parse(infos2[2]);
            float total = (preco2 * num2) + (preco1 * num1);
            Console.WriteLine("TOTAL A PAGAR: R$"+total.ToString("F2"));
            Console.ReadLine();
        }
    }
}
