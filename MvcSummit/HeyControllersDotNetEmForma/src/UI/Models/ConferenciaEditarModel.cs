using System;

namespace Exemplo.UI.Models
{
	public class ConferenciaEditarModel
	{
		public Guid Id { get; set; }
		public string Nome { get; set; }

		public ParticipanteEditarModel[] Participantes { get; set; }

		public class ParticipanteEditarModel
		{
			public Guid Id { get; set; }
			public string Nome { get; set; }
			public string Sobrenome { get; set; }
			public string Email { get; set; }
		}
	}
}