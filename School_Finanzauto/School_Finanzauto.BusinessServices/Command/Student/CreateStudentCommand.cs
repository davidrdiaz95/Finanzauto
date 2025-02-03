using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Services.Command.Student;
using School_Finanzauto.Services.Mapper;

namespace School_Finanzauto.BusinessServices.Command.Student
{
	public class CreateStudentCommand : ICreateStudentCommand
	{
		private readonly IRepository<Students> repository;
		private readonly IMapper<Students, StudentsDto> mapper;

		public CreateStudentCommand(IRepository<Students> repository,
			IMapper<Students, StudentsDto> mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		public async Task<bool> Execute(StudentsDto student)
		{
			var exist = this.repository.FindBy(x => x.Identification.Equals(student.Identification) || x.UserLogin.Equals(student.UserLogin));
			if (exist.Any())
				return false;

			var result = this.mapper.MapTo(student);
			result.DateCreate = DateTime.UtcNow;
			result.State = true;
			this.repository.Insert(result);
			return true;
		}
	}
}
