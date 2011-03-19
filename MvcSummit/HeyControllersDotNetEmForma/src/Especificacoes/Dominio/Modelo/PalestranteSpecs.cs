using Exemplo.Dominio.Modelo;
using Machine.Specifications;

namespace TestesUnitarios.Dominio.Modelo
{
	[Subject(typeof(Palestrante))]
	public class quando_o_palestrante_eh_criado
	{
		static string sobrenome = "Sobrenome";
		static string nome = "Nome";
		static Palestrante palestrante;

		Because of = () => palestrante = new Palestrante(nome, sobrenome);

		It deve_ter_o_nome_definido = () => palestrante.Nome.ShouldEqual(nome);
		
		It deve_ter_o_sobrenome_definido = () => palestrante.Sobrenome.ShouldEqual(sobrenome);
	}

	[Subject(typeof(Palestrante))]
	public class quando_uma_palestra_eh_registrada
	{
		static Palestrante palestrante;
		private static Palestra palestra;

		Establish context = () =>
		                            	{
		                            		palestrante = new Palestrante("nome", "sobrenome");
		                            		palestra = new Palestra("titulo", "resumo", palestrante);
		                            	};

		Because of = () => palestrante.Registrar(palestra);

		It esta_deve_ser_incluida_nas_palestras_do_palestrante =
			() => palestrante.TodasPalestras().ShouldContain(palestra);
	}
}