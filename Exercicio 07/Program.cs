using System;

namespace Exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tipo de valor
            //string nome1 = "Luan";
            //string nome2 = nome1;

            //nome1 = "João";

            //Console.WriteLine($"{nameof(nome1)}:{nome1}");
            //Console.WriteLine($"{nameof(nome2)}:{nome2}");
            //Console.ReadLine();
            #endregion Tipo de valor
            #region Tipo referencia
            //E.Pessoa pessoa = new E.Pessoa()
            //{
            //    Nome = "Perez",
            //};

            //pessoa.Nome = "João";
            //Pessoa pessoa = new Pessoa(null);

            Pessoa pessoa1 = new Pessoa("Perez");
            Pessoa pessoa2 = pessoa1;

            Console.WriteLine($"{nameof(pessoa1)}:{pessoa1.Nome}");
            Console.WriteLine($"{nameof(pessoa2)}:{pessoa2.Nome}");

            Console.ReadLine();
            #endregion Tipo referencia
        }
    }
}

