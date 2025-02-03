using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Services.Command.Teacher;
using School_Finanzauto.Services.Mapper;

namespace School_Finanzauto.BusinessServices.Command.Teacher
{
	public class GetFinByIdentificationCommand : IGetFinByIdentificationCommand
	{
		private readonly IRepository<Teachers> repository;
		private readonly IMapper<Teachers, TeacherDto> mapper;

		public GetFinByIdentificationCommand(IRepository<Teachers> repository,
			IMapper<Teachers, TeacherDto> mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		public async Task<TeacherDto> Execute(long id)
		{
			var result = this.repository.SingleFindBy(x => x.Identification.Equals(id));
			if (result != null)
			{
				return this.mapper.MapFrom(result);
			}
			return null;
		}
	}
}
