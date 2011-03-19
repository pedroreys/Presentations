using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Exemplo.UI.Models
{
	public class ParticipanteEditarModelo
	{
		[HiddenInput(DisplayValue = false)]
		public Guid EventId { get; set; }

		[HiddenInput]
		public string NomeDoEvento { get; set; }

		[Required(ErrorMessage = "O nome é obrigatório")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O sobrenome é obrigatório")]
		public string Sobrenome { get; set; }

		[DisplayName("Endereço de Email")]
		[RegularExpression(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$", ErrorMessage = "Email Inválido")]
		public string Email { get; set; }
	}
}