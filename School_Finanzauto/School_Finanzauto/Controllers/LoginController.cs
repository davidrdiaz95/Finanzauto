using Microsoft.AspNetCore.Mvc;
using School_Finanzauto.Services.Service;

namespace School_Finanzauto.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class LoginController : ControllerBase
	{
		private readonly ILoginService loginService;

		public LoginController(ILoginService loginService)
		{
			this.loginService = loginService;
		}

		[HttpGet]
		public async Task<IActionResult> Login(string userName, string password)
		{
			return Ok(await this.loginService.LoginAsync(userName, password));
		}
	}
}
