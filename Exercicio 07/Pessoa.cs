using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_07
{
	class Pessoa
	{
		public string Nome { get; private set; }
		public Pessoa(string nome) { 
			Nome = nome ??
				throw new ArgumentException(nameof(nome));
		}

	}
}
