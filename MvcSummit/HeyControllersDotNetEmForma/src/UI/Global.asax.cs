using System.Web.Mvc;
using System.Web.Routing;
using Exemplo.Dominio.Modelo;
using Exemplo.Infraestrutura.Repositorios;
using Exemplo.UI.Helpers;
using StructureMap;

namespace Exemplo.UI
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}

		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"VerEvento",
				"Conferencia/{nomeEvento}/{action}",
				new { controller = "Conferencia", action = "Mostrar" });

			routes.MapRoute(
				"Default", // Route name
				"{controller}/{action}/{id}", // URL with parameters
				new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
			);

		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes);

			InicializadorAutoMapper.Inicializar();
			
			var dataLoader = ObjectFactory.GetInstance<DummyDataLoader>();

			dataLoader.Load();
		}
	}
}