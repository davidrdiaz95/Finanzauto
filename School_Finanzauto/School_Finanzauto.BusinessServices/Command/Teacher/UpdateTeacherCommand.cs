using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Services.Command.Teacher;

namespace School_Finanzauto.BusinessServices.Command.Teacher
{
	public class UpdateTeacherCommand : IUpdateTeacherCommand
	{
		private readonly IRepository<Teachers> repository;

		public UpdateTeacherCommand(IRepository<Teachers> repository)
		{
			this.repository = repository;
		}

		public async Task<bool> Execute(TeacherUpdateDto teacher)
		{
			var teacherEnty = this.repository.SingleFindBy(x => x.Id.Equals(teacher.Id));
			if (teacherEnty != null)
			{
				teacherEnty.Identification = teacher.Identification;
				teacherEnty.Name = teacher.Name;
				teacherEnty.State = teacher.State;
				teacherEnty.DateUpdate = DateTime.UtcNow;
				teacherEnty.FkIdUserUpdate = teacher.UserUpdate;
				this.repository.Update(teacherEnty);
				return true;
			}
			return false;
		}
	}
}
