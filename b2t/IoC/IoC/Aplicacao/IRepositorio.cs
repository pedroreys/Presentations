namespace IoC.Aplicacao
{
    public interface IRepositorio<T>
    {
        T BuscarPeloId(int identificador);
    }
}