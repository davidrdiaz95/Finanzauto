using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Command.Student
{
	public interface IGetStudentFinByIdentificationCommand
	{
		Task<StudentsDto> Execute(long id);
	}
}
