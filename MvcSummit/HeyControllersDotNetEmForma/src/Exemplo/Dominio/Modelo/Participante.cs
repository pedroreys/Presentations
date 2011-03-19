namespace Exemplo.Dominio.Modelo
{
	public class Participante : Entidade
	{
		public virtual string Nome { get; private set; }
		public virtual string Sobrenome { get; private set; }
		public virtual string Email { get; set; }
		public virtual Conferencia Conferencia { get; private set; }


		public Participante(string nome, string sobrenome)
		{
			Nome = nome;
			Sobrenome = sobrenome;
		}

		protected Participante(){}

		public virtual void AlterarNome(string nome, string sobrenome)
		{
			Nome = nome;
			Sobrenome = sobrenome;
		}

		public virtual void RegistrarPara(Conferencia conferencia)
		{
			Conferencia = conferencia;
			Conferencia.AdicionarParticipante(this);
		}
	}
}