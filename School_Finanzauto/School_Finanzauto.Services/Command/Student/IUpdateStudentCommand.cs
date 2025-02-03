using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Command.Student
{
	public interface IUpdateStudentCommand
	{
		Task<bool> Execute(StudentsUpdateDto studentsUpdate);
	}
}
