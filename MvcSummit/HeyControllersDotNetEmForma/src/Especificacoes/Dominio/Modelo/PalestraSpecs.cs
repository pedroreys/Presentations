using Exemplo.Dominio.Modelo;
using Machine.Specifications;

namespace TestesUnitarios.Dominio.Modelo
{
	[Subject(typeof(Palestra))]
	public class quando_a_palestra_eh_criada
	{
		private static Palestra palestra;
		private static string titulo = "titulo";
		private static string resumo = "resumo";
		public static Palestrante palestrante = new Palestrante("Nome","Sobrenome");

		Because of = () => palestra = new Palestra(titulo,resumo,palestrante);

		It deve_ter_o_titulo_definido = () => palestra.Titulo.ShouldEqual(titulo);

		It deve_ter_o_resumo_definido = () => palestra.Resumo.ShouldEqual(resumo);

		It deve_ter_o_palestrante_definido = () => palestra.Palestrante.ShouldEqual(palestrante);

		It o_palestrante_deve_ter_o_registro_da_palestra = () => palestrante.TodasPalestras().ShouldContain(palestra);
	}
}