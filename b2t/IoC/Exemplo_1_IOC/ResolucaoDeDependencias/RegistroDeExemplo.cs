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
					});
		}
	}
}