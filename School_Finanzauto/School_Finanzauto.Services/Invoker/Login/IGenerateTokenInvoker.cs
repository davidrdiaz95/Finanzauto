using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Invoker.Login
{
	public interface IGenerateTokenInvoker
	{
		Task<ResponseDTO<string>> Execute(string userName, string password);
	}
}
