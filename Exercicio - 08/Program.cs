using System;

namespace Exercicio___08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Chamada método extension

            //ImprimirVelocidadeFinal(new Cooper());
            //ImprimirVelocidadeFinal(new Fusca());

            #endregion Chamada método extension

            #region Classe partial

            //ImprimirMembrosHumano(new Humano());

            #endregion Classe partial

            #region Struct

            //PosicaoGPS posicaoGPS = new PosicaoGPS()
            //{
            //    Latitude = 50.00m,
            //    Longitude = -15.00m,
            //};

            var posicaoGPS = new PosicaoGPS(15.00m, -50.00m);

            Console.WriteLine("Está no hesmisfério norte: " +
                $"{posicaoGPS.IsHemisferioNorte()}");

            #endregion Struct

            Console.ReadLine();
        }

        static void ImprimirVelocidadeFinal(AbstractCarro carro)
        {
            Console.WriteLine(carro.ObterVelocidadeFinal());
        }

        static void ImprimirMembrosHumano(Humano humano)
        {
            Console.WriteLine($"{humano.Bracos} - {humano.Quadril}");
        }
    }
}
