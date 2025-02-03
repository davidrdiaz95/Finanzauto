using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Service
{
	public interface ILoginService
	{
		Task<ResponseDTO<string>> LoginAsync(string userName, string password);
	}
}
