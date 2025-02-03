using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Services.Command.Teacher;
using School_Finanzauto.Services.Mapper;

namespace School_Finanzauto.BusinessServices.Command.Teacher
{
	public class CreateTeacherCommand : ICreateTeacherCommand
	{
		private readonly IRepository<Teachers> repository;
		private readonly IMapper<Teachers, TeacherDto> mapper;

		public CreateTeacherCommand(IRepository<Teachers> repository,
			 IMapper<Teachers, TeacherDto> mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		public async Task<bool> Execute(TeacherDto teacher)
		{
			var exist = this.repository.FindBy(x => x.Identification.Equals(teacher.Identification) || x.UserLogin.Equals(teacher.UserLogin));
			if (exist.Any())
				return false;

			var teacherEntity = this.mapper.MapTo(teacher);
			teacherEntity.DateCreate = DateTime.UtcNow;
			teacherEntity.State = true;
			this.repository.Insert(teacherEntity);
			return true;
		}
	}
}
