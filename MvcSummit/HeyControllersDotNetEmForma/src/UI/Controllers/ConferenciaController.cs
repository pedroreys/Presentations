using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Exemplo.Dominio.Modelo;
using Exemplo.Dominio.Repositorios;
using Exemplo.UI.Models;

namespace Exemplo.UI.Controllers
{
	public class ConferenciaController : Controller
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

			return View(modelo);
		}

		public ActionResult Mostrar(string nomeEvento)
		{

			var conf = _repositorio.RetornaPeloNome(nomeEvento);

			var modelo = Mapper.Map<Conferencia, ConferenciaMostrarModelo>(conf);

			return View(modelo);

		}

		public ActionResult Editar(string nomeEvento)
		{

			var conf = _repositorio.RetornaPeloNome(nomeEvento);

			var modelo = Mapper.Map<Conferencia, ConferenciaEditarModelo>(conf);
			
			return View(modelo);
		}

		[HttpPost]
		public ActionResult Editar(ConferenciaEditarModelo form)
		{
			if(!ModelState.IsValid)
			{
				return View(form);
			}

			var conf = _repositorio.RetornaPeloId(form.Id);

			conf.AlterarNome(form.Nome);

			foreach (var participanteEditarModelo in conf.GetParticipantes())
			{
				var participante = conf.RetornaParticipante(participanteEditarModelo.Id);
				participante.AlterarNome(participanteEditarModelo.Nome,participanteEditarModelo.Sobrenome);
				participante.Email = participanteEditarModelo.Email;
			}

			return RedirectToAction("Index");
		}
		
	}
}