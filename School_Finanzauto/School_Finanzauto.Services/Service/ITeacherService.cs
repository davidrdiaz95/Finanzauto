using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Service
{
	public interface ITeacherService
	{
		Task<ResponseDTO<string>> CreateTechaer(TeacherDto teacher);
		Task<ResponseDTO<string>> UpdateTechaer(TeacherUpdateDto teacher);
		Task<ResponseDTO<TeacherDto>> GetFinByIdentification(long id);
	}
}
