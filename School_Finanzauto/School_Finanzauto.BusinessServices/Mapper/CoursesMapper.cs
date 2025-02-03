using School_Finanzauto.Model.Dto;
using School_Finanzauto.Services.Mapper;

namespace School_Finanzauto.BusinessServices.Mapper
{
	public class CoursesMapper : IMapper<Repository.Entity.Course, CoursesDto>
	{
		public CoursesDto MapFrom(Repository.Entity.Course model)
		{
			var result = new CoursesDto();
			result.Name = model.Name;
			result.IdUserCreate = model.FkIdUserCreate.Value;
			return result;
		}

		public Repository.Entity.Course MapTo(CoursesDto model)
		{
			var result = new Repository.Entity.Course();
			result.Name = model.Name;
			result.FkIdUserCreate = model.IdUserCreate;
			return result;
		}
	}
}
