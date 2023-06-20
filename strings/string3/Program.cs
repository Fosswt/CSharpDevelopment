using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int qtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string allIn = Console.ReadLine();
            string[] all = allIn.Split(' ');
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(precoProduto);
            Console.WriteLine(all[0]);
            Console.WriteLine(all[1]);
            Console.WriteLine(all[2]);
            Console.ReadLine();
        }
    }
}
