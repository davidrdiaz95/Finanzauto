using School_Finanzauto.Model.Dto;
using School_Finanzauto.Model.Util;
using School_Finanzauto.Services.Command.Student;
using School_Finanzauto.Services.Service;

namespace School_Finanzauto.BusinessServices.Service
{
	public class StudentService : IStudentService
	{
		private readonly ICreateStudentCommand createStudentCommand;
		private readonly IUpdateStudentCommand updateStudentCommand;
		private readonly IGetStudentFinByIdentificationCommand getStudentFinByIdentificationCommand;
		private readonly IDeleteStudentCommand deleteStudentCommand;
		private readonly IGetRatingForIdentificationCommand getRatingForIdentificationCommand;

		public StudentService(ICreateStudentCommand createStudentCommand,
			IUpdateStudentCommand updateStudentCommand,
			IGetStudentFinByIdentificationCommand getStudentFinByIdentificationCommand,
			IDeleteStudentCommand deleteStudentCommand,
			IGetRatingForIdentificationCommand getRatingForIdentificationCommand)
		{
			this.createStudentCommand = createStudentCommand;
			this.updateStudentCommand = updateStudentCommand;
			this.getStudentFinByIdentificationCommand = getStudentFinByIdentificationCommand;
			this.deleteStudentCommand = deleteStudentCommand;
			this.getRatingForIdentificationCommand = getRatingForIdentificationCommand;
		}


		public async Task<ResponseDTO<string>> CreateStudent(StudentsDto studentsDto)
		{
			var result = await this.createStudentCommand.Execute(studentsDto);
			return result ?
				ResponseStatus.ResponseSucessful<string>("se registro correctamente el estudiante") :
				ResponseStatus.ResponseWithoutData<string>("No se pudo registrar el estudiante");
		}

		public async Task<ResponseDTO<string>> DeleteFinByIdentification(long id)
		{
			var result = await this.deleteStudentCommand.Execute(id);
			return result ?
				ResponseStatus.ResponseSucessful<string>("se elimino correctamente el estudiante") :
				ResponseStatus.ResponseWithoutData<string>("No existe el estudiante");
		}

		public async Task<ResponseDTO<StudentsDto>> GetFinByIdentification(long id)
		{
			var result = await this.getStudentFinByIdentificationCommand.Execute(id);
			return result != null ?
				ResponseStatus.ResponseSucessful<StudentsDto>(result) :
				ResponseStatus.ResponseWithoutData<StudentsDto>("No se encontro el estudiante");
		}

		public async Task<ResponseDTO<IEnumerable<RatingStudentDTO>>> GetRatingForIdentification(long id)
		{
			var result = await this.getRatingForIdentificationCommand.Execute(id);
			return result != null ?
				ResponseStatus.ResponseSucessful<IEnumerable<RatingStudentDTO>>(result) :
				ResponseStatus.ResponseWithoutData<IEnumerable<RatingStudentDTO>>("No se encontraron notas");
		}

		public async Task<ResponseDTO<string>> UpdateStudent(StudentsUpdateDto studentsUpdate)
		{
			var result = await this.updateStudentCommand.Execute(studentsUpdate);
			return result ?
				ResponseStatus.ResponseSucessful<string>("se modificar correctamente el estudiante") :
				ResponseStatus.ResponseWithoutData<string>("No se pudo modificar el estudiante");
		}
	}
}
