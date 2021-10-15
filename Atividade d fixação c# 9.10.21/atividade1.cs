using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)Desenvolva um programa que mostre na tela a tabuada do 4.

            // Recebe as Variaveis
            int formula, contador, numero;


            Console.WriteLine("TABUADA DO 4 ABAIXO !");
            numero = 4;

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