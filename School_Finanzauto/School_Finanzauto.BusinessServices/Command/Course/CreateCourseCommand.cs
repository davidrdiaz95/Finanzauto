using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Services.Command.Course;
using School_Finanzauto.Services.Mapper;

namespace School_Finanzauto.BusinessServices.Command.Course
{
	public class CreateCourseCommand : ICreateCourseCommand
	{
		private readonly IRepository<Repository.Entity.Course> repository;
		private readonly IMapper<Repository.Entity.Course, CoursesDto> mapper;

		public CreateCourseCommand(IRepository<Repository.Entity.Course>  repository,
			 IMapper<Repository.Entity.Course, CoursesDto> mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		public async Task<bool> Execute(CoursesDto courses)
		{

			//var existe = this.repository.FindBy(x => x.Name.Equals(courses.Name));
			//if (existe.Any())
			//	return false;

			var response = this.mapper.MapTo(courses);
			response.State = true;
			response.DateCreate = DateTime.UtcNow;
			response.TeachersId = courses.IdUserCreate;
			this.repository.Insert(response);
			return true;
		}
	}
}
