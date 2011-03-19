using System;
using System.Linq;
using System.Threading;
using Exemplo.Dominio.Modelo;
using Exemplo.Infraestrutura.Repositorios;
using Machine.Specifications;

namespace Especificacoes.Infraestrutura.Repositorios
{
	[Subject(typeof(RepositorioDeConferencias))]
	public class quando_uma_nova_conferencia_eh_salva
	{
		private static Repositorio<Conferencia> repositorio;
		private static Conferencia conferencia;

		Establish context = () =>
									{
										repositorio = new RepositorioDeConferencias();
										conferencia = new Conferencia("nome");
									};

		Because of = () => repositorio.Salvar(conferencia);

		It deve_ser_possivel_a_recuperar_pelo_id = () => repositorio.RetornaPeloId(conferencia.Id).ShouldEqual(conferencia);

		It deve_ter_um_id_atribuido = () => conferencia.Id.ShouldNotEqual(Guid.Empty);

		It deve_ser_persistida_na_colecao_de_conferencias = () => repositorio.Todos().ShouldContain(conferencia);
	}

	[Subject(typeof(RepositorioDeConferencias))]
	public class quando_uma_conferencia_ja_existente_eh_salva
	{
		private static Repositorio<Conferencia> repositorio;
		private static Conferencia conferencia;
		private static string nomeAlterado = "novo nome";
		Establish context = () =>
		{
			repositorio = new RepositorioDeConferencias();
			conferencia = new Conferencia("nome"){Id = Guid.NewGuid()};
			conferencia.AlterarNome(nomeAlterado);
		};

		Because of = () => repositorio.Salvar(conferencia);

		It as_alteracoes_devem_ser_salvas = () => repositorio.RetornaPeloId(conferencia.Id).Nome.ShouldEqual(nomeAlterado);
	}

	[Subject(typeof(RepositorioDeConferencias))]
	public class quando_uma_conferencia_eh_removida
	{
		private static Repositorio<Conferencia> repositorio;
		private static Conferencia conferencia;
		private static string nomeAlterado = "novo nome";

		Establish context = () =>
		{
			repositorio = new RepositorioDeConferencias();
			conferencia = new Conferencia("nome");
			repositorio.Salvar(conferencia);
		};

		Because of = () => repositorio.Remover(conferencia);

		It nao_deve_ser_encontrada_nenhuma_conferencia_com_o_mesmo_id = () => repositorio.RetornaPeloId(conferencia.Id).ShouldBeNull();

		It deve_ser_removida_da_colecao = () => repositorio.Todos().ShouldNotContain(conferencia);
	}

	[Subject(typeof(RepositorioDeConferencias))]
	public class quando_uma_conferencia_eh_salva_usando_uma_instancia_do_repositorio
	{
		private static Conferencia _conferencia;
		private static RepositorioDeConferencias _repositorioAnterior;

		Establish contexto = () =>
		                      	{
		                      		_conferencia = new Conferencia("conferencia1");
		                      		_repositorioAnterior = new RepositorioDeConferencias();
		                      	};

		Because of = () =>
		                     	{
		                     		var repo1 = new RepositorioDeConferencias();
		                     		repo1.Salvar(_conferencia);
		                     	};

		It esta_deve_ser_acessivel_por_uma_instancia_do_repositorio_que_foi_criada_posteriormente = () =>
		                  	{
		                  		var repo2 = new RepositorioDeConferencias();
		                  		repo2.RetornaPeloNome(_conferencia.Nome).ShouldEqual(_conferencia);
		                  	};


		It esta_deve_ser_acessivel_por_uma_instancia_do_repositorio_que_foi_criada_anteriormente = () =>
		{
			_repositorioAnterior.RetornaPeloNome(_conferencia.Nome).ShouldEqual(_conferencia);
		};
	}
}