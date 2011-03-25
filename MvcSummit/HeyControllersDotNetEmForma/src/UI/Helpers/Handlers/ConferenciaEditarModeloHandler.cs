using Exemplo.Dominio.Repositorios;
using Exemplo.UI.Models;

namespace Exemplo.UI.Helpers.Handlers
{
	public class ConferenciaEditarModeloHandler : IFormHandler<ConferenciaEditarModelo>
	{
		private readonly IRepositorioDeConferencias _repositorio;

		public ConferenciaEditarModeloHandler(IRepositorioDeConferencias repositorio)
		{
			_repositorio = repositorio;
		}

		public void Handle(ConferenciaEditarModelo form)
		{
			var conf = _repositorio.RetornaPeloId(form.Id);

			conf.AlterarNome(form.Nome);

			foreach (var participanteEditarModelo in conf.GetParticipantes())
			{
				var participante = conf.RetornaParticipante(participanteEditarModelo.Id);
				participante.AlterarNome(participanteEditarModelo.Nome, participanteEditarModelo.Sobrenome);
				participante.Email = participanteEditarModelo.Email;
			}
		}
	}
}