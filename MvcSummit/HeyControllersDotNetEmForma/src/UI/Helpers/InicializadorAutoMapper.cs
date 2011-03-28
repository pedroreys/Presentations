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
							cfg.AddProfile<ViewModelProfile>();
							cfg.AddProfile<EditModelProfile>();
						});

		}
	}

	public class ViewModelProfile : Profile
	{
		protected override void Configure()
		{
			CreateMap<Conferencia, ConferenciaListarModel>();
			CreateMap<Conferencia, ConferenciaMostrarModel>();
			CreateMap<Palestra, ConferenciaMostrarModel.PalestraModel>();
			CreateMap<Participante, ConferenciaMostrarModel.ParticipanteModel>();
		}
	}

	public class EditModelProfile : Profile
	{
		protected override void Configure()
		{
			CreateMap<Conferencia, ConferenciaEditarModel>();
			CreateMap<Participante, ConferenciaEditarModel.ParticipanteEditarModel>();
		}
	}


}