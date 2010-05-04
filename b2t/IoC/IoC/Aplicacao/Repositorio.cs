namespace IoC.Aplicacao
{
    public class Repositorio<T> : IRepositorio<T> where T : new()
    {
        private readonly IConexaoBancoDeDados _conexaoBancoDeDados;

        public Repositorio(IConexaoBancoDeDados conexaoBancoDeDados)
        {
            _conexaoBancoDeDados = conexaoBancoDeDados;
        }

        public T BuscarPeloId(int identificador)
        {
            _conexaoBancoDeDados.GaranteQueEstaConectado();
            return new T();
        }
    }
}