using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    class Program
    {

        //3) Elabore um programa que mostre a média aritmética de 15 números digitados pelo usuário.
        static void Main(string[] args)
        {

            int soma, numero, i, resultado;

            soma = 0;

            for (i = 1; i <=15; i++)
            {
                Console.WriteLine("Escreva "+ i +" numero: ");
                numero = int.Parse(Console.ReadLine());

                soma = soma + numero;

            }

            resultado = soma / 15;
            Console.WriteLine("A média aritmética dos números é igual a " + resultado);

            Console.ReadKey();
        }

    }
}
