using System;

namespace IoC.Aplicacao
{
    public class LoggerDoEnviadorDeEmail : IEnviadorDeEmail
    {
        private readonly IEnviadorDeEmail _interno;

        public LoggerDoEnviadorDeEmail(IEnviadorDeEmail interno)
        {
            _interno = interno;
        }

        public void Enviar(string Mensagem)
        {
            _interno.Enviar(Mensagem);
            Console.WriteLine("Logger: Email Logado!");
        }
    }
}