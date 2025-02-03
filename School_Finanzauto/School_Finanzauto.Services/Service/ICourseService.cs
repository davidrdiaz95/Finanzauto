using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Service
{
	public interface ICourseService
	{
		Task<ResponseDTO<string>> CreateCourse(CoursesDto coursesDto);
		Task<ResponseDTO<IEnumerable<CoursesDto>>> GetAll();
	}
}
