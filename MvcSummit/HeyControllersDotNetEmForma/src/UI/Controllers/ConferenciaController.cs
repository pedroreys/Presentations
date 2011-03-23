using System.Linq;
using System.Web.Mvc;
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
								.Select(conf => new ConferenciaListarModelo
				        		{
				        			Id = conf.Id,
				        			Nome = conf.Nome,
				        			QuantidadeDePalestras = conf.QuantidadeDePalestras,
				        			QuantidadeDeParticipantes = conf.QuantidadeDeParticipantes
				        		});
			return View(lista);
		}

		public ActionResult Mostrar(string nomeEvento)
		{

			var conf = _repositorio.RetornaPeloNome(nomeEvento);

			var modelo = new ConferenciaMostrarModelo
			             	{
			             		Nome = conf.Nome,
			             		Palestras = conf.TodasPalestras()
			             			.Select(p => new ConferenciaMostrarModelo.ModeloPalestra()
			             			{
			             			    Titulo = p.Titulo,
			             			    PalestranteNome = p.Palestrante.Nome,
			             			    PalestranteSobrenome = p.Palestrante.Sobrenome
			             			}).ToArray(),

								Participantes = conf.TodosParticipantes()
								.Select(p => new ConferenciaMostrarModelo.ModeloParticipante()
								             	{
								             		Nome = p.Nome,
													Sobrenome = p.Sobrenome,
													Email = p.Email
								             	}).ToArray()
			             	};

			return View(modelo);

		}

		public ActionResult Editar(string nomeEvento)
		{

			var conf = _repositorio.RetornaPeloNome(nomeEvento);

			var model = new ConferenciaEditarModelo
			{
				Id = conf.Id,
				Nome = conf.Nome,
				Participantes = conf.TodosParticipantes()
								.Select(p => new ConferenciaEditarModelo.ParticipanteEditarModelo()
								{
									Nome = p.Nome,
									Sobrenome = p.Sobrenome,
									Email = p.Email
								}).ToArray(),
			};


			return View(model);
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

			foreach (var participanteEditarModelo in conf.TodosParticipantes())
			{
				var participante = conf.RetornaParticipante(participanteEditarModelo.Id);
				participante.AlterarNome(participanteEditarModelo.Nome,participanteEditarModelo.Sobrenome);
				participante.Email = participanteEditarModelo.Email;
			}

			return RedirectToAction("Index");
		}
		
	}
}