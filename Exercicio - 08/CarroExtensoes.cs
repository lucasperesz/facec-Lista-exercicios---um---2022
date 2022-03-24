using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___08
{
    public static class CarroExtensoes
    {
        public static string ObterVelocidadeFinal(this AbstractCarro carro)
        {
            return $"{carro.ObterMarca()} - {carro.ObterModelo()} :" +
                $"{carro.ObterVelocidade()} Km/h \n";
        }
    }
}
