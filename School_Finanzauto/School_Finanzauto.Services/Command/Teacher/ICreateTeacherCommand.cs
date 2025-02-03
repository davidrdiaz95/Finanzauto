using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Command.Teacher
{
	public interface ICreateTeacherCommand
	{
		Task<bool> Execute(TeacherDto teacher);
	}
}
