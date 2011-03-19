using System;

namespace Exemplo.UI.Models
{
	public class ConferenciaMostrarModelo
	{

		public Guid Id { get; set; }
		public string Nome { get; set; }


		public ModeloPalestra[] Palestras { get; set; }
		public ModeloParticipante[] Participantes { get; set; }

		public class ModeloPalestra
		{
			public string PalestranteNome { get; set; }

			public string PalestranteSobrenome { get; set; }

			public string Titulo { get; set; }
		}

		public class ModeloParticipante
		{
			public string Nome { get; set; }

			public string Sobrenome { get; set; }

			public string Email { get; set; }
		}
	}
}
