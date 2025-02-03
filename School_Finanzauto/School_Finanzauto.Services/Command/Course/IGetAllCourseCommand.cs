using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Command.Course
{
	public interface IGetAllCourseCommand
	{
		Task<IEnumerable<CoursesDto>> Execute();
	}
}
