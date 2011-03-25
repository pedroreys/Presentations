using System.Web.Mvc;
using Exemplo.Dominio.Repositorios;

namespace Exemplo.UI.Helpers
{
	public class ConferenciaModelBinder : IModelBinder
	{
		private readonly IRepositorioDeConferencias _repositorio;

		public ConferenciaModelBinder(IRepositorioDeConferencias repositorio)
		{
			_repositorio = repositorio;
		}

		public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
		{
			ValueProviderResult value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

			var conferencia = _repositorio.RetornaPeloNome(value.AttemptedValue);

			return conferencia;
		}
	}
}