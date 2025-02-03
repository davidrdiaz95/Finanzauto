namespace School_Finanzauto.Services.Command.Login
{
	public interface IGetLoginStudentCommand
	{
		Task<bool> Execute(string userName, string password);
	}
}
