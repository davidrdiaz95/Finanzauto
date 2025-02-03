using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Command.Rating
{
	public interface ICreateRatingCommand
	{
		Task<bool> Execute(RatingDto rating);
	}
}
