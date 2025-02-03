using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Services.Command.Student;

namespace School_Finanzauto.BusinessServices.Command.Student
{
	public class DeleteStudentCommand : IDeleteStudentCommand
	{
		private readonly IRepository<Students> repository;

		public DeleteStudentCommand(IRepository<Students> repository)
		{
			this.repository = repository;
		}

		public async Task<bool> Execute(long id)
		{
			var exist = this.repository.SingleFindBy(x => x.Identification.Equals(id));
			if (exist != null)
			{
				exist.State = false;
				exist.DateUpdate = DateTime.UtcNow;
				this.repository.Update(exist);
				return true;

			}
			return false;
		}
	}
}
