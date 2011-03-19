using System;
using Exemplo.Dominio.Modelo;
using Machine.Specifications;

namespace TestesUnitarios.Dominio.Modelo
{
	[Subject(typeof(Participante))]
	public class quando_o_participante_eh_criado
	{
		static string nome;
		static string sobrenome;
		static Participante participante;

		Establish context = () =>
		                        {
									nome = "nome";
									sobrenome = "sobrenome";
		                        };
		

		Because of = () => participante = new Participante(nome, sobrenome);

		It deve_ter_o_nome_definido = () => participante.Nome.ShouldEqual(nome);

		It deve_ter_o_sobrenome_definido = () => participante.Sobrenome.ShouldEqual(sobrenome);
	}

	[Subject(typeof(Participante))]
	public class quando_o_nome_do_participante_eh_alterado
	{
		static string nomeAlterado;
		static string sobrenomeAlterado;
		static Participante participante;

		Establish context = () =>
		                        {
		                            participante = new Participante("nome", "sobrenome");
		                            nomeAlterado = "nome alterado";
		                            sobrenomeAlterado = "sobrenome alterado";
		                        };

		Because of = () => participante.AlterarNome(nomeAlterado, sobrenomeAlterado);

		It deve_ter_o_nome_alterado = () => participante.Nome.ShouldEqual(nomeAlterado);

		It deve_ter_o_sobrenome_alterado = () => participante.Sobrenome.ShouldEqual(sobrenomeAlterado);
	}

	[Subject(typeof(Participante))]
	public class quando_se_registra_para_uma_conferencia
	{
		static Conferencia conferencia;
		static Participante participante;

		Establish context = () =>
		                    	{
		                    		participante = new Participante("nome", "sobrenome"){Id = Guid.NewGuid()};
		                            conferencia = new Conferencia("nome da conferencia");
		                        };

		Because of = () => participante.RegistrarPara(conferencia);

		It deve_referenciar_a_conferencia_para_qual_se_registrou = () =>
			participante.Conferencia.ShouldEqual(conferencia);

		It deve_ser_adicionado_a_conferencia = () =>
		    conferencia.RetornaParticipante(participante.Id).ShouldEqual(participante);
	}

}