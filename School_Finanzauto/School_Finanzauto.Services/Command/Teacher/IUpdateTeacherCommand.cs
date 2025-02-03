using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Command.Teacher
{
	public interface IUpdateTeacherCommand
	{
		Task<bool> Execute(TeacherUpdateDto teacher);
	}
}
