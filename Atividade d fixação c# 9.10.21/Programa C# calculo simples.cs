using System;

namespace Aula1_Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(value: "teste de programa");
            int a, b, total;
            a = 20;
            b = NewMethod();
            Console.WriteLine(a + " + " + b + " =" + (a + b));
            total = a - b;
            Console.WriteLine(a + " - " + b + " = " + total);
            Console.WriteLine(a + " * " + b + " = " + (a * b)); 
            Console.WriteLine(a + " / " + b + " = " + (a / b));
            Console.WriteLine(a + " % " + b + " = " + (a % b));
            Console.ReadKey();
        }

        private static int NewMethod()
        {
            return 10;
        }
    }
}
