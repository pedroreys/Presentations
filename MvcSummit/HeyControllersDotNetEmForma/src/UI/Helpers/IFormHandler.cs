namespace Exemplo.UI.Helpers
{
	public interface IFormHandler<T>
	{
		void Handle(T form);
	}
}