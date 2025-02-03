using School_Finanzauto.Model.Dto;
using School_Finanzauto.Model.Util;
using School_Finanzauto.Services.Command.Course;
using School_Finanzauto.Services.Service;

namespace School_Finanzauto.BusinessServices.Service
{
	public class CourseService : ICourseService
	{
		private readonly ICreateCourseCommand createCourseCommand;
		private readonly IGetAllCourseCommand getAllCourseCommand;

		public CourseService(ICreateCourseCommand createCourseCommand,
			IGetAllCourseCommand getAllCourseCommand)
		{
			this.createCourseCommand = createCourseCommand;
			this.getAllCourseCommand = getAllCourseCommand;
		}

		public async Task<ResponseDTO<string>> CreateCourse(CoursesDto coursesDto)
		{
			var result = await this.createCourseCommand.Execute(coursesDto);
			return result ?
				ResponseStatus.ResponseSucessful<string>("se registro correctamente el cusro") :
				ResponseStatus.ResponseWithoutData<string>("No se pudo registrar el curso");
		}

		public async Task<ResponseDTO<IEnumerable<CoursesDto>>> GetAll()
		{
			var result = await this.getAllCourseCommand.Execute();
			return result.Any() ?
				ResponseStatus.ResponseSucessful<IEnumerable<CoursesDto>>(result) :
				ResponseStatus.ResponseWithoutData<IEnumerable<CoursesDto>>("No se encontraron cursos");
		}
	}
}
