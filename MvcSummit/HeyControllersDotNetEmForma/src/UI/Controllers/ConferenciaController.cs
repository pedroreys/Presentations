using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Exemplo.Dominio.Modelo;
using Exemplo.Dominio.Query;
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

			var lista = _repositorio.Query()
								.Where(conf => conf.QuantidadeDePalestras >= qtdMinPalestras)
								.ToArray();

			var modelo = Mapper.Map<Conferencia[], ConferenciaListarModelo[]>(lista);

			return AutoMapView<ConferenciaListarModelo[]>(View(modelo));
		}

		public ActionResult Mostrar(Conferencia nomeEvento)
		{
			return AutoMapView<ConferenciaMostrarModelo>(View(nomeEvento));
		}

		public ActionResult Editar(Conferencia nomeEvento)
		{
			return AutoMapView<ConferenciaEditarModelo>(View(nomeEvento));
		}

		[HttpPost]
		public ActionResult Editar(ConferenciaEditarModelo form)
		{
			var successResult = RedirectToAction("Index");

			return Form(form, successResult);
		}
		
	}
}