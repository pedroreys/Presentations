using AutoMapper;
using Exemplo.Dominio.Modelo;
using Exemplo.UI.Models;

namespace Exemplo.UI.Helpers
{
	public static class InicializadorAutoMapper
	{
		public static void Inicializar()
		{
			Mapper.Initialize(cfg =>
			{
				cfg.AddProfile<ViewModeloProfile>();
				cfg.AddProfile<EditarModeloProfile>();
			});
		}
	}

	public class ViewModeloProfile : Profile
	{
		protected override void Configure()
		{
			CreateMap<Conferencia, ConferenciaListarModelo>();
			CreateMap<Conferencia, ConferenciaMostrarModelo>();
			CreateMap<Palestra, ConferenciaMostrarModelo.ModeloPalestra>();
			CreateMap<Participante, ConferenciaMostrarModelo.ModeloParticipante>();
		}
	}

	public class EditarModeloProfile : Profile
	{
		protected override void Configure()
		{
			CreateMap<Conferencia, ConferenciaEditarModelo>();
			CreateMap<Participante, ConferenciaEditarModelo.ParticipanteEditarModelo>();
		}
	}
}