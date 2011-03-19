namespace Exemplo.Dominio.Modelo
{
	public class Palestra : Entidade
	{
		public virtual string Titulo { get; private set; }
		public virtual string Resumo { get; private set; }
		public virtual Palestrante Palestrante { get; private set; }
		public virtual Conferencia Conferencia { get; protected internal set; }

		public Palestra(string titulo, string resumo, Palestrante palestrante)
		{
			Titulo = titulo;
			Resumo = resumo;
			Palestrante = palestrante;

			palestrante.Registrar(this);
		}

		public Palestra() {}
	}
}