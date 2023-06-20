using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
            exemplo
             */
            Console.WriteLine("1.Álcool 2.Gasolina 3.Diesel 4.Fim");
            int choice = int.Parse(Console.ReadLine());
            int qtdAlcool = 0;
            int qtdGasolina = 0;
            int qtdDiesel = 0;
            while (choice != 4)
            {
                Console.WriteLine("1.Álcool 2.Gasolina 3.Diesel 4.Fim");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    qtdAlcool += 1;
                }
                else if(choice == 2)
                {
                    qtdGasolina += 1;
                }
                else if (choice == 3)
                {
                    qtdDiesel += 1;
                }
                else
                {
                    Console.WriteLine("input inválido.");
                }
            }
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"ÁLCOOL: ${qtdAlcool}");
            Console.WriteLine($"GASOLINA: ${qtdGasolina}");
            Console.WriteLine($"DIESEL: ${qtdDiesel}");
            Console.ReadLine();

        }
    }
}
