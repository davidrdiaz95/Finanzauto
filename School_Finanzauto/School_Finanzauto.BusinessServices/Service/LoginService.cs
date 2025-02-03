using School_Finanzauto.Model.Dto;
using School_Finanzauto.Services.Invoker.Login;
using School_Finanzauto.Services.Service;

namespace School_Finanzauto.BusinessServices.Service
{
	public class LoginService : ILoginService
	{
		private readonly IGenerateTokenInvoker generateTokenInvoker;

		public LoginService(IGenerateTokenInvoker generateTokenInvoker)
		{
			this.generateTokenInvoker = generateTokenInvoker;
		}

		public async Task<ResponseDTO<string>> LoginAsync(string userName, string password)
		{
			return await this.generateTokenInvoker.Execute(userName, password);
		}
	}
}
