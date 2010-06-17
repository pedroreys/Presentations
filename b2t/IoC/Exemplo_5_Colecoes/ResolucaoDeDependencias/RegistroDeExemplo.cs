using System.Collections.Generic;
using Exemplo.Aplicacao;
using StructureMap.Configuration.DSL;

namespace Exemplo.ResolucaoDeDependencias
{
	public class RegistroDeExemplo : Registry
	{
		public RegistroDeExemplo()
		{
			Scan(x =>
					{
						x.TheCallingAssembly();

						x.AddAllTypesOf<IRegraDeFormatacao>();

						x.WithDefaultConventions();
					});

			For(typeof(IRepositorio<>)).Use(typeof(Repositorio<>));

			For<IEnviadorDeEmail>().EnrichAllWith(x => new LoggerDeEmail(x));

		}
	}
}