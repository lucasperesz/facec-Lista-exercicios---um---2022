using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___08
{
    public abstract class AbstractCarro
    {
        public abstract string ObterMarca();
        public abstract string ObterModelo();
        public abstract int ObterVelocidade();

        // não permite sobrescrita
        //public string RelatorioDeManutencao()
        //{
        //    return $"{ObterMarca()} -" +
        //        $" {ObterModelo()}\n" +
        //        $"TESTE TESTE";
        //}

        //visivel em outro assembly
        //public virtual string RelatorioDeManutencao()
        //{
        //    return $"{ObterMarca()} -" +
        //        $" {ObterModelo()}\n" +
        //        $"TESTE TESTE";
        //}

        internal virtual string RelatorioDeManutencao()
        {
            return $"{ObterMarca()} -" +
                $" {ObterModelo()}\n" +
                $"TESTE TESTE";
        }
    }
}
