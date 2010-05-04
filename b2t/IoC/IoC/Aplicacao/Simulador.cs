using IoC.Aplicacao.Modelo;

namespace IoC.Aplicacao
{
    public class Simulador : ISimulador
    {
        private readonly IEnviadorDeSMS _enviadorDeSMS;
        private IEnviadorDeEmail _enviadorDeEmail;
        private readonly IRepositorio<Simulacao> _repositorioDeSimulacao;

        public Simulador(IEnviadorDeSMS enviadorDeSMS, IEnviadorDeEmail enviadorDeEmail, IRepositorio<Simulacao> repositorioDeSimulacao)
        {
            _enviadorDeSMS = enviadorDeSMS;
            _enviadorDeEmail = enviadorDeEmail;
            _repositorioDeSimulacao = repositorioDeSimulacao;
        }

        public void Simular()
        {
            _enviadorDeSMS.Enviar();
            var simulacao = _repositorioDeSimulacao.BuscarPeloId(1);
            _enviadorDeEmail.Enviar(simulacao.Dados);
        }
    }
}