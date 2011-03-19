using Exemplo.Infraestrutura.Repositorios;
using StructureMap.Configuration.DSL;

namespace Exemplo.Infraestrutura.ResolucaoDeDependencias
{
	public class RegistroDeDependenciasPrincipal : Registry
	{
		public RegistroDeDependenciasPrincipal()
		{
			Scan(cfg =>
			{
				cfg.TheCallingAssembly();
				cfg.WithDefaultConventions();
				cfg.ConnectImplementationsToTypesClosing(typeof (Repositorio<>));
			});
		}
	}
}