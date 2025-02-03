using School_Finanzauto.Model.Dto;
using School_Finanzauto.Model.Util;
using School_Finanzauto.Services.Command.Rating;
using School_Finanzauto.Services.Service;

namespace School_Finanzauto.BusinessServices.Service
{
	public class RatingService : IRatingService
	{
		private readonly ICreateRatingCommand createRatingCommand;

		public RatingService(ICreateRatingCommand createRatingCommand)
		{
			this.createRatingCommand = createRatingCommand;
		}

		public async Task<ResponseDTO<string>> CreateRating(RatingDto courses)
		{
			var result = await this.createRatingCommand.Execute(courses);
			return result ?
				ResponseStatus.ResponseSucessful<string>("se registro correctamente la nota") :
				ResponseStatus.ResponseWithoutData<string>("No se pudo registrar la nota");
		}
	}
}
