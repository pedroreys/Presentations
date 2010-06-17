using StructureMap;

namespace Exemplo.ResolucaoDeDependencias
{
	public class Registrador
	{
		private static bool _dependenciasEstaoRegistradas;

		public static void GarantaQueAsDependenciasEstaoRegistradas()
		{
			if (!_dependenciasEstaoRegistradas)
				ConfigurarStructureMap();
		}

		private static void ConfigurarStructureMap()
		{
			ObjectFactory.Initialize(x => x.AddRegistry<RegistroDeExemplo>());

			ObjectFactory.AssertConfigurationIsValid();
			_dependenciasEstaoRegistradas = true;
		}
	}
}