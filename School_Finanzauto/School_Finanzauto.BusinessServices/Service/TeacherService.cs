using School_Finanzauto.Model.Dto;
using School_Finanzauto.Model.Util;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Services.Command.Teacher;
using School_Finanzauto.Services.Service;

namespace School_Finanzauto.BusinessServices.Service
{
	public class TeacherService : ITeacherService
	{
		private readonly ICreateTeacherCommand createTeacherCommand;
		private readonly IUpdateTeacherCommand updateTeacherCommand;
		private readonly IGetFinByIdentificationCommand getFinByIdentificationCommand;

		public TeacherService(ICreateTeacherCommand createTeacherCommand,
			IUpdateTeacherCommand updateTeacherCommand,
			IGetFinByIdentificationCommand getFinByIdentificationCommand)
		{
			this.createTeacherCommand = createTeacherCommand;
			this.updateTeacherCommand = updateTeacherCommand;
			this.getFinByIdentificationCommand = getFinByIdentificationCommand;
		}

		public async Task<ResponseDTO<string>> CreateTechaer(TeacherDto teacher)
		{
			var result = await this.createTeacherCommand.Execute(teacher);
			return result ?
				ResponseStatus.ResponseSucessful<string>("Se registro correctamente el profesor") :
				ResponseStatus.ResponseWithoutData<string>("No se pudo registrar el profesor");
		}

		public async Task<ResponseDTO<TeacherDto>> GetFinByIdentification(long id)
		{
			var result = await this.getFinByIdentificationCommand.Execute(id);
			return result != null ?
				ResponseStatus.ResponseSucessful<TeacherDto>(result) :
				ResponseStatus.ResponseWithoutData<TeacherDto>("No se pudo registrar el profesor");
		}

		public async Task<ResponseDTO<string>> UpdateTechaer(TeacherUpdateDto teacher)
		{
			var result = await this.updateTeacherCommand.Execute(teacher);
			return result ?
				ResponseStatus.ResponseSucessful<string>("Se modifico correctamente el profesor") :
				ResponseStatus.ResponseWithoutData<string>("No se pudo modificar el profesor");
		}
	}
}
