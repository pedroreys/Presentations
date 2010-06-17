using Exemplo.Aplicacao;
using StructureMap.Configuration.DSL;

namespace Exemplo.ResolucaoDeDependencias
{
	public class RegistroDeExemplo :Registry
	{
		public RegistroDeExemplo()
		{
			Scan(x =>
					{
						x.TheCallingAssembly();
						x.WithDefaultConventions();
						x.ConnectImplementationsToTypesClosing(typeof (IHandlerDeMensagem<>));
					});

			For<IConexaoComBd>()
				.Use<ConexaoComOracle>()
				.Ctor<string>().Is("BancoDeDados=ServidorOracle");
		}
	}
}