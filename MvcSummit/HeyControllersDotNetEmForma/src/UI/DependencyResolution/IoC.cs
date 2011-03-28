using System.Web.Mvc;
using Exemplo.Infraestrutura.Repositorios;
using Exemplo.UI.Helpers;
using StructureMap;
namespace Exemplo.UI
{
	public static class IoC
	{
		public static IContainer Initialize()
		{

			ObjectFactory.Initialize(x =>
				{
					x.Scan(scan =>
							{
								scan.TheCallingAssembly();
								scan.AssemblyContainingType(typeof(Repositorio<>));
								scan.ConnectImplementationsToTypesClosing(typeof(Repositorio<>));
								scan.AddAllTypesOf<IModelBinderProvider>();
								scan.ConnectImplementationsToTypesClosing(typeof(IFormHandler<>));
								scan.WithDefaultConventions();
							});

				});

			return ObjectFactory.Container;
		}
	}
}