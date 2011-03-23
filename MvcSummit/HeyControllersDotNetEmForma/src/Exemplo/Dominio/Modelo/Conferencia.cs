using System;
using System.Collections.Generic;
using System.Linq;
using Iesi.Collections.Generic;

namespace Exemplo.Dominio.Modelo
{
	public class Conferencia : Entidade
	{
		private readonly Iesi.Collections.Generic.ISet<Participante> _participantes = new HashedSet<Participante>();
		private readonly Iesi.Collections.Generic.ISet<Palestra> _palestras = new HashedSet<Palestra>();

		public virtual string Nome { get; private set; }
		public virtual int QuantidadeDeParticipantes { get; private set; }
		public virtual int QuantidadeDePalestras { get; private set; }

		public Conferencia(string nome)
		{
			Nome = nome;
			QuantidadeDeParticipantes = 0;
			QuantidadeDePalestras = 0;
		}

		protected Conferencia(){}

		public void AlterarNome(string nome)
		{
			Nome = nome;
		}

		public virtual IEnumerable<Participante> GetParticipantes()
		{
			return _participantes;
		}

		public virtual Participante RetornaParticipante(Guid idParticipante)
		{
			return _participantes.First(participante => participante.Id == idParticipante);
		}

		public void AdicionarParticipante(Participante participante)
		{
			_participantes.Add(participante);
			QuantidadeDeParticipantes++;
		}

		public virtual IEnumerable<Palestra> GetPalestras()
		{
			return _palestras;
		}

		public virtual Palestra RetornaPalestra(Guid idPalestra)
		{
			return _palestras.First(palestra => palestra.Id == idPalestra);
		}

		public virtual void AdicionarPalestra(Palestra palestra)
		{
			_palestras.Add(palestra);
			palestra.Conferencia = this;
			QuantidadeDePalestras++;
		}
	}
}