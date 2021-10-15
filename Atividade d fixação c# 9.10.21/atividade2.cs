using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //2)Desenvolva um programa que mostre na tela uma tabuada escolhida pelo usuário.

            // Recebe as Variaveis
            int formula, contador, numero;


            Console.Write("Digite o Numero para Obter a Taboada : ");
            numero = int.Parse(Console.ReadLine());

            //para
            for (contador =1; contador <=10; contador++)
            {
                formula = numero * contador;
                Console.WriteLine(numero + " X " + contador + " = " + formula);

            }

            Console.ReadKey();
        }

    }
}