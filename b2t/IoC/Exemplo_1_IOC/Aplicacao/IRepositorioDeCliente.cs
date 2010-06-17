using System;

namespace Exemplo.Aplicacao
{
	public interface IRepositorioDeCliente
	{
		Cliente BuscarPeloId(int i);
	}
}