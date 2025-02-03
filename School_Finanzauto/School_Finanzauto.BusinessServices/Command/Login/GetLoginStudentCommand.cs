using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Services.Command.Login;

namespace School_Finanzauto.BusinessServices.Command.Login
{
	public class GetLoginStudentCommand : IGetLoginStudentCommand
	{
		private readonly IRepository<Students> repository;

		public GetLoginStudentCommand(IRepository<Students> repository)
		{
			this.repository = repository;
		}

		public async Task<bool> Execute(string userName, string password)
		{
			var login = this.repository.FindByInclude(x => x.UserLogin.Equals(userName) && x.PasswordLogin.Equals(password));
			return login.Any() ?true : false;
		}
	}
}
