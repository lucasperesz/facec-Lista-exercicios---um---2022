﻿using System;

namespace exercicio___dois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo!");
            static void test()
            {
                Console.Write("Valor em Reais? ");
                float reais = float.Parse(Console.ReadLine());

                double usd = reais / 5.22;

                Console.WriteLine("$ = " + usd);
            }
        }
    }
}
