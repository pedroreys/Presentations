using IoC.Aplicacao;
using ResolucaoDeDependencias;

namespace IoC
{
    public class MinhaAplicacao
    {
        public void Main()
        {
            var simulador = ServiceLocator.BuscaInstanciaDe<ISimulador>();
            simulador.Simular();
        }
    }
}
