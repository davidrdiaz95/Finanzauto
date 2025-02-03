namespace School_Finanzauto.Services.Command.Login
{
	public interface IGetLoginTeacherCommand
	{
		Task<bool> Execute(string userName, string password);
	}
}
