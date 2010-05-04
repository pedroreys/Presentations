using System;

namespace IoC.Aplicacao
{
    public interface IConexaoBancoDeDados
    {
        void GaranteQueEstaConectado();
    }

    public class ConexaoBancoDeDados : IConexaoBancoDeDados
    {
        public void GaranteQueEstaConectado()
        {
            Console.WriteLine("Banco de Dados Conectado!");
        }
    }
}