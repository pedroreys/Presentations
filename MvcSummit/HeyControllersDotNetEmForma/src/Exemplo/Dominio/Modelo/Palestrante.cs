using System.Collections.Generic;
using Iesi.Collections.Generic;

namespace Exemplo.Dominio.Modelo
{
	public class Palestrante
	{
		private readonly Iesi.Collections.Generic.ISet<Palestra> _palestras = new HashedSet<Palestra>();

		public virtual string Nome { get; private set; }
		public virtual string Sobrenome { get; private set; }
		public virtual string Bio { get; set; }

		public Palestrante(string nome, string sobrenome)
		{
			Nome = nome;
			Sobrenome = sobrenome;
		}

		protected  Palestrante(){}

		public virtual IEnumerable<Palestra>  TodasPalestras()
		{
			return _palestras;
		}

		public virtual void Registrar(Palestra palestra)
		{
			_palestras.Add(palestra);
		}
	}
}
