using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using School_Finanzauto.Model.Dto;
using School_Finanzauto.Model.Section;
using School_Finanzauto.Model.Util;
using School_Finanzauto.Services.Command.Login;
using School_Finanzauto.Services.Invoker.Login;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace School_Finanzauto.BusinessServices.Invoker.Login
{
	public class GenerateTokenInvoker : IGenerateTokenInvoker
	{
		private readonly TokenConfiguration tokenConfiguration;
		private readonly IOptions<TokenConfiguration> options;
		private readonly IGetLoginStudentCommand getLoginStudentCommand;
		private readonly IGetLoginTeacherCommand getLoginTeacherCommand;

		public GenerateTokenInvoker(IOptions<TokenConfiguration> options,
			IGetLoginStudentCommand getLoginStudentCommand,
			IGetLoginTeacherCommand getLoginTeacherCommand)
		{
			tokenConfiguration = options.Value;
			this.options = options;
			this.getLoginStudentCommand = getLoginStudentCommand;
			this.getLoginTeacherCommand = getLoginTeacherCommand;
		}

		public async Task<ResponseDTO<string>> Execute(string userName, string password)
		{
			List<Claim> claims = new List<Claim>();
			var user = await getLoginStudentCommand.Execute(userName, password);
			if (user)
				claims.Add(new Claim(ClaimTypes.Role, "Student"));
			else
			{
				user = await getLoginTeacherCommand.Execute(userName, password);
				if (user)
					claims.Add(new Claim(ClaimTypes.Role, "Teacher"));
				else
					return ResponseStatus.ResponseWithoutData<string>("No se encontro el usuario");
			}




			SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenConfiguration.Secrect));
			SigningCredentials creds = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
			JwtSecurityToken token = new JwtSecurityToken(
				claims: claims,
				expires: DateTime.Now.AddSeconds(tokenConfiguration.ExpirationTime),
				signingCredentials: creds);

			return token != null ?
				ResponseStatus.ResponseSucessful(new JwtSecurityTokenHandler().WriteToken(token)) :
				ResponseStatus.ResponseWithoutData<string>("No se encontro el usuario");
		}
	}
}
