using System;

namespace Exemplo.UI.Models
{
	public class ConferenciaListarModelo
	{
		public Guid Id { get; set; }
		public string Nome { get; set; }
		public int QuantidadeDePalestras { get; set; }
		public int QuantidadeDeParticipantes { get; set; }
	}
}