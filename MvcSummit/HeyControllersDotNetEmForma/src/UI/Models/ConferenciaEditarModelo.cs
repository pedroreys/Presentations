using System;

namespace Exemplo.UI.Models
{
	public class ConferenciaEditarModelo
	{
		public Guid Id { get; set; }
		public string Nome { get; set; }

		public ParticipanteEditarModelo[] Participantes { get; set; }

		public class ParticipanteEditarModelo
		{
			public Guid Id { get; set; }
			public string Nome { get; set; }
			public string Sobrenome { get; set; }
			public string Email { get; set; }
		}
	}
}