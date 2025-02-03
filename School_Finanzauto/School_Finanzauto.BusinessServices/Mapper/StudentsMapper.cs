using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Services.Mapper;

namespace School_Finanzauto.BusinessServices.Mapper
{
	public class StudentsMapper : IMapper<Students, StudentsDto>
	{
		public StudentsDto MapFrom(Students model)
		{
			var result = new StudentsDto();
			result.Name = model.Name;
			result.IdUserCreate = model.FkIdUserCreate.Value;
			result.UserLogin = model.UserLogin;
			result.Identification = model.Identification;
			result.Age = model.Age;
			result.FkIdCourse = model.FkIdCourse;
			result.PasswordLogin = model.PasswordLogin;
			return result;
		}

		public Students MapTo(StudentsDto model)
		{
			var result = new Students();
			result.Name = model.Name;
			result.FkIdUserCreate = model.IdUserCreate;
			result.UserLogin = model.UserLogin;
			result.Identification = model.Identification;
			result.Age = model.Age;
			result.FkIdCourse = model.FkIdCourse;
			result.PasswordLogin = model.PasswordLogin;
			return result;
		}
	}
}
