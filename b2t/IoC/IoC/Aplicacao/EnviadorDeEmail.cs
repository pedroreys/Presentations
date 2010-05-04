using System;

namespace IoC.Aplicacao
{
    public class EnviadorDeEmail : IEnviadorDeEmail
    {
        private readonly IFormatadorDeEmail _formatador;

        public EnviadorDeEmail(IFormatadorDeEmail formatador)
        {
            _formatador = formatador;
        }

        public void Enviar(string mensagem)
        {
            var mensagemFormatada = _formatador.Formatar(mensagem);
            Console.WriteLine("EnviadorDeEmail: \"{0}\" foi enviada.", mensagemFormatada);
        }
    }
}