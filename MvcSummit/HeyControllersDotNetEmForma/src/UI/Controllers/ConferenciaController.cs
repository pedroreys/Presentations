using System.Linq;
using System.Web.Mvc;
using Exemplo.Dominio.Repositorios;
using Exemplo.Infraestrutura.Repositorios;
using Exemplo.UI.Models;

namespace Exemplo.UI.Controllers
{
	public class ConferenciaController : DefaultController
	{
		private IRepositorioDeConferencias _repositorio;

		public ConferenciaController()
		{
			_repositorio = new RepositorioDeConferencias();
		}

		public ActionResult Index(int? qtdMinPalestras)
		{
			qtdMinPalestras = qtdMinPalestras ?? 0;

			var confs = _repositorio.Query()
								.Where(conf => conf.QuantidadeDePalestras >= qtdMinPalestras);

			var modelo = confs.Select(conf => new ConferenciaListarModel
			{
				Id = conf.Id,
				Nome = conf.Nome,
				QuantidadeDePalestras = conf.QuantidadeDePalestras,
				QuantidadeDeParticipantes = conf.QuantidadeDeParticipantes
			});
			return View(modelo);
		}

		public ActionResult Mostrar(string nomeEvento)
		{

			var conf = _repositorio.RetornaPeloNome(nomeEvento);

			var modelo = new ConferenciaMostrarModel
			{
				Nome = conf.Nome,
				Palestras = conf.GetPalestras()
					.Select(p => new ConferenciaMostrarModel.PalestraModel()
					{
						Titulo = p.Titulo,
						PalestranteNome = p.Palestrante.Nome,
						PalestranteSobrenome = p.Palestrante.Sobrenome
					}).ToArray(),

				Participantes = conf.GetParticipantes()
				.Select(p => new ConferenciaMostrarModel.ParticipanteModel()
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

			var model = new ConferenciaEditarModel
			{
				Id = conf.Id,
				Nome = conf.Nome,
				Participantes = conf.GetParticipantes()
								.Select(p => new ConferenciaEditarModel.ParticipanteEditarModel()
								{
									Nome = p.Nome,
									Sobrenome = p.Sobrenome,
									Email = p.Email
								}).ToArray(),
			};


			return View(model);
		}

		[HttpPost]
		public ActionResult Editar(ConferenciaEditarModel form)
		{
			if (!ModelState.IsValid)
			{
				return View(form);
			}

			var conf = _repositorio.RetornaPeloId(form.Id);

			conf.AlterarNome(form.Nome);

			foreach (var participanteEditarModelo in conf.GetParticipantes())
			{
				var participante = conf.RetornaParticipante(participanteEditarModelo.Id);
				participante.AlterarNome(participanteEditarModelo.Nome, participanteEditarModelo.Sobrenome);
				participante.Email = participanteEditarModelo.Email;
			}

			return RedirectToAction("Index");
		}

	}
}