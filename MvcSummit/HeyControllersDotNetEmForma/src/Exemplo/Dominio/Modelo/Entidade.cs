using System;

namespace Exemplo.Dominio.Modelo
{
	public abstract class Entidade
	{

		public virtual Guid Id { get; set; }

		public virtual bool EhPersistente
		{
			get { return !EhTransiente(); }
		}

		public override bool Equals(object obj)
		{
			if (!EhTransiente())
			{
				var objetoPersistente = obj as Entidade;
				return (objetoPersistente != null) && (Id == objetoPersistente.Id);
			}

			return base.Equals(obj);
		}

		public static bool operator ==(Entidade esquerda, Entidade direita)
		{
			return Equals(esquerda, direita);
		}

		public static bool operator !=(Entidade esquerda, Entidade direita)
		{
			return !Equals(esquerda, direita);
		}

		public override int GetHashCode()
		{
			if (EhTransiente())
			{
				return base.GetHashCode();
			}

			return Id.GetHashCode();
		}

		private bool EhTransiente()
		{
			return Equals(Id, Guid.Empty);
		}
	}
}
