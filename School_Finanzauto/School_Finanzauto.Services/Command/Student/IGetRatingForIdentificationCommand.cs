using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Command.Student
{
	public interface IGetRatingForIdentificationCommand
	{
		Task<IEnumerable<RatingStudentDTO>> Execute(long id);
	}
}
