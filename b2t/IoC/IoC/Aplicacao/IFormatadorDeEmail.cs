using System;

namespace IoC.Aplicacao
{
    public interface IFormatadorDeEmail
    {
        string Formatar(string mensagem);
    }

    public class FormatadorDeEmail : IFormatadorDeEmail
    {
        private readonly IRegraDeFormatacao[] _regras;

        public FormatadorDeEmail(IRegraDeFormatacao[] regras)
        {
            _regras = regras;
        }

        public string Formatar(string mensagem)
        {
            foreach (var regra in _regras)
            {
                mensagem = regra.Formatar(mensagem);
            }

            return mensagem;
        }
    }
}