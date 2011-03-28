using System.Web.Mvc;
using Exemplo.UI.Helpers;

namespace Exemplo.UI.Controllers
{
	public class DefaultController : Controller
	{
		protected AutoMapViewResult AutoMapView<TDestination>(ViewResult viewResult)
		{
			return new AutoMapViewResult(
				viewResult.ViewData.Model.GetType(),
				typeof(TDestination),
				viewResult);
		}

		protected FormActionResult<TForm> Form<TForm>(TForm form, ActionResult success)
		{
			var failure = View(form);

			return new FormActionResult<TForm>(form,success,failure);
		}


	}
}