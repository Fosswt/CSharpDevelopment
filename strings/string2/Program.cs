using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ler um número inteiro
            try
            {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou "+num);
            }
            catch (Exception)
            {

                Console.WriteLine("kkkk");
            }
            char letra = char.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou " + letra);
            Console.ReadLine();
        }
    }
}
