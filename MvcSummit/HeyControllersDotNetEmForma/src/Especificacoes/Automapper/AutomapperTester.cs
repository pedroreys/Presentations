using AutoMapper;
using Machine.Specifications;

namespace Especificacoes.Automapper
{
	public class Configuracoes_do_AutoMapper
	{
		private It devem_ser_validas = () => Mapper.AssertConfigurationIsValid();
	}
}