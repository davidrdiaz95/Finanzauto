using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Command.Course
{
	public interface ICreateCourseCommand
	{
		Task<bool> Execute(CoursesDto courses);
	}
}
