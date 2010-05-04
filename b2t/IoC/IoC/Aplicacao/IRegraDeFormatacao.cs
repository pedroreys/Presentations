namespace IoC.Aplicacao
{
    public interface IRegraDeFormatacao
    {
        string Formatar(string mensagem);
    }

    public class AvisoRegraDeFormatacao : IRegraDeFormatacao
    {
        public string Formatar(string mensagem)
        {
            return mensagem + "\nEssa mensagem se auto destruirá apos ser lida.";
        }
    }

    public class ParaMaiusculaRegraDeFormatacao : IRegraDeFormatacao
    {
        public string Formatar(string mensagem)
        {
            return mensagem.ToUpper();
        }
    }
}