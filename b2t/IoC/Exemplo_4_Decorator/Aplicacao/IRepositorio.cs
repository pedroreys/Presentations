namespace Exemplo.Aplicacao
{
	public interface IRepositorio<T>
	{
		T BuscarPeloId(int id);
	}
}