using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Service
{
	public interface IRatingService
	{
		Task<ResponseDTO<string>> CreateRating(RatingDto courses);
	}
}
