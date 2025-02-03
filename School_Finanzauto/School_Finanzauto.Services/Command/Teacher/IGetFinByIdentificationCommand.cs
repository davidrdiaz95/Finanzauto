using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Command.Teacher
{
	public interface IGetFinByIdentificationCommand
	{
		Task<TeacherDto> Execute(long id);
	}
}
