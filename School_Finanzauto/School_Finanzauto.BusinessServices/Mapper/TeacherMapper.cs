using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Services.Mapper;

namespace School_Finanzauto.BusinessServices.Mapper
{
	public class TeacherMapper : IMapper<Teachers, TeacherDto>
	{
		public TeacherDto MapFrom(Teachers model)
		{
			var result = new TeacherDto();
			result.Name = model.Name;
			result.Identification = model.Identification;
			result.UserCreate = model.FkIdUserCreate.Value;
			result.State = model.State;
			result.UserLogin = model.UserLogin;
			result.PasswordLogin = model.PasswordLogin;
			return result;
		}

		public Teachers MapTo(TeacherDto model)
		{
			var result = new Teachers();
			result.Name = model.Name;
			result.Identification = model.Identification;
			result.FkIdUserCreate = model.UserCreate;
			result.State = model.State;
			result.UserLogin = model.UserLogin;
			result.PasswordLogin = model.PasswordLogin;
			return result;
		}
	}
}
