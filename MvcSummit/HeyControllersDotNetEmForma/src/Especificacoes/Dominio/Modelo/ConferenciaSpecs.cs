using System;
using Machine.Specifications;
using Exemplo.Dominio.Modelo;

namespace TestesUnitarios.Dominio.Modelo
{
	[Subject(typeof(Conferencia))]
	public class quando_a_conferencia_eh_criada
	{
		private static Conferencia conferencia;
		private static string nomeDaConferencia = "Nome da Conferencia";

		Because of = () => conferencia = new Conferencia(nomeDaConferencia);

		It deve_ter_o_nome_definido = () => conferencia.Nome.ShouldEqual(nomeDaConferencia);

		It nao_deve_possuir_nenhum_participante = () => conferencia.QuantidadeDeParticipantes.ShouldEqual(0);

		It nao_deve_possuir_nenhuma_palestra = () => conferencia.QuantidadeDePalestras.ShouldEqual(0);
	}

	[Subject(typeof(Conferencia))]
	public class quando_um_participante_eh_adicionado
	{
		static Conferencia conferencia;
		static Participante participante;

		private Establish context = () =>
										{
											conferencia = new Conferencia("Nome da Conferencia");
											participante = new Participante("Nome do Participante", "Sobrenome do Participante")
											{
												Id = Guid.NewGuid()
											};
										};

		Because of = () => conferencia.AdicionarParticipante(participante);

		It a_quantidade_de_participantes_deve_ser_incrementada = () => conferencia.QuantidadeDeParticipantes.ShouldEqual(1);

		It deve_retornar_o_participante_a_partir_do_seu_id = () => conferencia.RetornaParticipante(participante.Id).ShouldEqual(participante);

		It deve_constar_na_colecao_de_todos_os_participantes = () => conferencia.GetParticipantes().ShouldContain(participante);
	}

	[Subject(typeof(Conferencia))]
	public class quando_uma_palestra_eh_adicionada
	{
		static Conferencia conferencia;
		static Palestra palestra;

		private Establish context = () =>
		{
			conferencia = new Conferencia("Nome da Conferencia");
			palestra = new Palestra("Nome do Participante", "Sobrenome do Participante", new Palestrante("nome","sobrenome"))
			{
				Id = Guid.NewGuid()
			};
		};

		Because of = () => conferencia.AdicionarPalestra(palestra);

		It a_quantidade_de_palestras_deve_ser_incrementada = () => conferencia.QuantidadeDePalestras.ShouldEqual(1);

		It deve_retornar_a_palestra_a_partir_do_seu_id = () => conferencia.RetornaPalestra(palestra.Id).ShouldEqual(palestra);

		It deve_constar_na_colecao_de_todos_as_palestras = () => conferencia.GetPalestras().ShouldContain(palestra);
	}
}