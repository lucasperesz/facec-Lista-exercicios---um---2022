using System;

namespace exercicio___02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo!");
            static void Main()
            {
                Console.Write("Valor em Reais? ");
                float reais = float.Parse(Console.ReadLine());

                double usd = reais / 5.22;

                Console.WriteLine("$ = " + usd);
            }
        }
    }
}