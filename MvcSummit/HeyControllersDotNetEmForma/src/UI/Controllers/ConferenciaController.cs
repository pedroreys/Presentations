using System.Linq;
using System.Web.Mvc;
using Exemplo.Dominio.Modelo;
using Exemplo.Dominio.Repositorios;
using Exemplo.UI.Models;

namespace Exemplo.UI.Controllers
{
	public class ConferenciaController : DefaultController
	{
		private IRepositorioDeConferencias _repositorio;

		public ConferenciaController(IRepositorioDeConferencias repositorio)
		{
			_repositorio = repositorio;
		}

		public ActionResult Index(int? qtdMinPalestras)
		{
			qtdMinPalestras = qtdMinPalestras ?? 0;

			var confs = _repositorio.Query().Where(conf => conf.QuantidadeDePalestras >= qtdMinPalestras).ToArray();

			return AutoMapView<ConferenciaListarModel[]>(View(confs));
		}

		public ActionResult Mostrar(Conferencia nomeEvento)
		{
			return AutoMapView<ConferenciaMostrarModel>(View(nomeEvento));
		}

		public ActionResult Editar(Conferencia nomeEvento)
		{
			return AutoMapView<ConferenciaEditarModel>(View(nomeEvento));
		}

		[HttpPost]
		public ActionResult Editar(ConferenciaEditarModel form)
		{
			var successResult = RedirectToAction("Index");

			return Form(form, successResult);
		}
	}
}