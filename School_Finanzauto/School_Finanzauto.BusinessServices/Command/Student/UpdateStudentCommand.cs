using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Services.Command.Student;

namespace School_Finanzauto.BusinessServices.Command.Student
{
	public class UpdateStudentCommand : IUpdateStudentCommand
	{
		private readonly IRepository<Students> repository;

		public UpdateStudentCommand(IRepository<Students> repository)
		{
			this.repository = repository;
		}

		public async Task<bool> Execute(StudentsUpdateDto studentsUpdate)
		{
			var student = this.repository.SingleFindBy(x => x.Id.Equals(studentsUpdate.Id));
			if (student != null)
			{
				student.State = studentsUpdate.State;
				student.Name = studentsUpdate.Name;
				student.Age = studentsUpdate.Age;
				student.FkIdCourse = studentsUpdate.FkIdCourse;
				student.Identification = studentsUpdate.Identification;
				student.PasswordLogin = studentsUpdate.PasswordLogin;
				student.UserLogin = studentsUpdate.UserLogin;
				student.DateUpdate = DateTime.UtcNow;
				student.FkIdUserUpdate = student.FkIdUserUpdate;
				this.repository.Update(student);
				return true;
			}
			return false;
		}
	}
}
