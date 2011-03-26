using System;

namespace Exemplo.UI.Models
{
	public class ConferenciaMostrarModel
	{
		public Guid Id { get; set; }
		public string Nome { get; set; }

		public PalestraModel[] Palestras { get; set; }
		public ParticipanteModel[] Participantes { get; set; }

		public class PalestraModel
		{
			public string PalestranteNome { get; set; }

			public string PalestranteSobrenome { get; set; }

			public string Titulo { get; set; }
		}

		public class ParticipanteModel
		{
			public string Nome { get; set; }

			public string Sobrenome { get; set; }

			public string Email { get; set; }
		}
	}
}
