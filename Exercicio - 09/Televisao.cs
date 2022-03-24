using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___09
{
    public class Televisao : IEletroDomestico
    {
        public void Desligar()
        {
            Console.Write($"{nameof(Televisao)} Desligou! \n");
        }

        public void Ligar()
        {
            Console.Write($"{nameof(Televisao)} Ligou!\n");
        }
    }
}
