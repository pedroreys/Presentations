using System;
using StructureMap;

namespace Exemplo.ResolucaoDeDependencias
{
	public class ServiceLocator
	{
		public static T Get<T>() where T : new()
		{
			Registrador.GarantaQueAsDependenciasEstaoRegistradas();
			return ObjectFactory.GetInstance<T>();
		}

		public static object Get(Type type)
		{
			Registrador.GarantaQueAsDependenciasEstaoRegistradas();
			return ObjectFactory.GetInstance(type);
		}
	}
}