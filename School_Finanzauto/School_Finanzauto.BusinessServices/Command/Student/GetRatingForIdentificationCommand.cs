using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Services.Command.Student;

namespace School_Finanzauto.BusinessServices.Command.Student
{
	public class GetRatingForIdentificationCommand : IGetRatingForIdentificationCommand
	{
		private readonly IRepository<Students> repository;

		public GetRatingForIdentificationCommand(IRepository<Students> repository)
		{
			this.repository = repository;
		}

		public async Task<IEnumerable<RatingStudentDTO>> Execute(long id)
		{
			var result = this.repository.SingleFindByInclude(x => x.Identification.Equals(id), x => x.Ratings);
			if (result != null)
			{
				return result.Ratings.Select(x=> new RatingStudentDTO
				{
					IdentificationStudent = result.Identification,
					IdTeacher = x.FkIdUserCreate.Value,
					IdCurse = x.FkIdCourse,
					Note = x.Note
				});
			}
			return null;
		}
	}
}
