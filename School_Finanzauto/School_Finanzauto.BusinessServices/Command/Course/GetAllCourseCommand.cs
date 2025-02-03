using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Services.Command.Course;
using School_Finanzauto.Services.Mapper;

namespace School_Finanzauto.BusinessServices.Command.Course
{
	public class GetAllCourseCommand : IGetAllCourseCommand
	{
		private readonly IRepository<Repository.Entity.Course> repository;
		private readonly IMapper<Repository.Entity.Course, CoursesDto> mapper;

		public GetAllCourseCommand(IRepository<Repository.Entity.Course> repository,
			IMapper<Repository.Entity.Course, CoursesDto> mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		public async Task<IEnumerable<CoursesDto>> Execute()
		{
			var result = this.repository.All();
			return result.Select(c => this.mapper.MapFrom(c));
		}
	}
}
