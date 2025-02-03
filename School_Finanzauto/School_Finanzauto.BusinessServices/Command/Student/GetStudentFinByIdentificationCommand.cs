using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Services.Command.Student;
using School_Finanzauto.Services.Mapper;

namespace School_Finanzauto.BusinessServices.Command.Student
{
	public class GetStudentFinByIdentificationCommand : IGetStudentFinByIdentificationCommand
	{
		private readonly IRepository<Students> repository;
		private readonly IMapper<Students, StudentsDto> mapper;

		public GetStudentFinByIdentificationCommand(IRepository<Students> repository,
			IMapper<Students, StudentsDto> mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		public async Task<StudentsDto> Execute(long id)
		{
			var result = this.repository.SingleFindBy(x => x.Identification == id);
			if (result != null)
				return this.mapper.MapFrom(result);
			else
				return null;
		}
	}
}
