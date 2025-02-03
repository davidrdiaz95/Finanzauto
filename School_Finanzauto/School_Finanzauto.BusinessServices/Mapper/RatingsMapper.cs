using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Services.Mapper;

namespace School_Finanzauto.BusinessServices.Mapper
{
	public class RatingsMapper : IMapper<Ratings, RatingDto>
	{
		public RatingDto MapFrom(Ratings model)
		{
			var result = new RatingDto();
			result.Note = model.Note;
			result.FkIdCourse = model.FkIdCourse;
			result.FkIdStudent = model.FkIdStudent;
			return result;
		}

		public Ratings MapTo(RatingDto model)
		{
			var result = new Ratings();
			result.Note = model.Note;
			result.FkIdCourse = model.FkIdCourse;
			result.FkIdStudent = model.FkIdStudent;
			return result;
		}
	}
}
