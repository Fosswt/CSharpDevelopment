using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
                mostre: 
                a) a área do triângulo retângulo que tem A por base e C por altura. 
                b) a área do círculo de raio C. (pi = 3.14159) 
                c) a área do trapézio que tem A e B por bases e C por altura. 
                d) a área do quadrado que tem lado B. 
                e) a área do retângulo que tem lados A e B
             */
            Console.WriteLine("Informe três valores com ponto flutuante de dupla precisão");
            string all = Console.ReadLine();
            string[] a = all.Split(' ');
            float v1 = float.Parse(a[0]);
            float v2 = float.Parse(a[1]);
            float v3 = float.Parse(a[2]);
            Console.WriteLine("TRIANGULO: "+ (v1 * v3) /2);
            Console.WriteLine("CÍRCULO: "+ (v3 * v3) * 3.14159);
            Console.WriteLine("TRAPÉZIO: " + (v1 + v2) * v3/2);
            Console.WriteLine("QUADRADO: " + v2 * v2);
            Console.WriteLine("RETÂNGULO: " + v1 * v2);
            Console.ReadLine();
        }
    }
}
