using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Services.Command.Rating;
using School_Finanzauto.Services.Mapper;

namespace School_Finanzauto.BusinessServices.Command.Rating
{
	public class CreateRatingCommand : ICreateRatingCommand
	{
		private readonly IRepository<Ratings> repository;
		private readonly IMapper<Ratings, RatingDto> mapper;

		public CreateRatingCommand(IRepository<Ratings> repository,
			IMapper<Ratings, RatingDto> mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		public async Task<bool> Execute(RatingDto rating)
		{
			var result = this.mapper.MapTo(rating);
			result.FkIdUserCreate = rating.FkIdTeacher;
			result.DateCreate = DateTime.UtcNow;
			result.State = true;
			this.repository.Insert(result);
			return true;
		}
	}
}
