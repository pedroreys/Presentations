using System;

namespace IoC.Aplicacao
{
    public class EnviadorDeSMS : IEnviadorDeSMS
    {
        public void Enviar()
        {
            Console.WriteLine("SMS Enviado!");
        }
    }
}