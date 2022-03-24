using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___09
{
    public class Abajur : IIluminacao
    {
        public void Desligar()
        {
            Console.Write($"{nameof(Abajur)} Desligou! \n");
        }

        public void Ligar()
        {
            Console.Write($"{nameof(Abajur)} Ligou!\n");
        }

        public void ObterPotenciaLampada()
        {
            Console.Write($"{nameof(Abajur)} " +
                $"possui lâmpada de 100w de potencia!\n");
        }
    }
}
