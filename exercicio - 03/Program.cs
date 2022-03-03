using System;

namespace exercicio___03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a Distancia percorrida em KM!");
            string distanciaStr = Console.ReadLine();
            Console.WriteLine("Informe o gasto total de combustivel em Litros!");
            string gastoStr = Console.ReadLine();
            decimal distancia = 0.0m;
            decimal gasto = 0.0m;
            decimal media = 0.0m;

            decimal.TryParse(distanciaStr, out distancia);
            decimal.TryParse(gastoStr, out gasto);
            media = distancia / gasto;

            decimal.TryParse(distanciaStr, out distancia);
            decimal.TryParse(gastoStr, out gasto);
            media = distancia / gasto;

            Console.WriteLine($"Seu veiculo fez uma media de {media}KM/Litro");

        }
    }
}
