using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___08
{
    public struct PosicaoGPS
    {
        public decimal Latitude { get; private set; }
        public decimal Longitude { get; private set; }

        //após a declaração de um construtor com params
        //não é possivel declarar um construtor vazio
        //public PosicaoGPS() { }

        public PosicaoGPS(decimal latitude, decimal longidute)
        {
            Latitude = latitude;
            Longitude = longidute;
        }

        public bool IsHemisferioNorte()
        {
            return Latitude > 0;
        }
    }
}
