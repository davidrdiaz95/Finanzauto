namespace School_Finanzauto.Services.Command.Student
{
	public interface IDeleteStudentCommand
	{
		Task<bool> Execute(long id);
	}
}
