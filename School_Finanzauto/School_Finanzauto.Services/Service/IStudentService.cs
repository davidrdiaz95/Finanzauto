using School_Finanzauto.Model.Dto;

namespace School_Finanzauto.Services.Service
{
	public interface IStudentService
	{
		Task<ResponseDTO<string>> CreateStudent(StudentsDto studentsDto);
		Task<ResponseDTO<string>> UpdateStudent(StudentsUpdateDto studentsUpdate);
		Task<ResponseDTO<StudentsDto>> GetFinByIdentification(long id);
		Task<ResponseDTO<string>> DeleteFinByIdentification(long id);
		Task<ResponseDTO<IEnumerable<RatingStudentDTO>>> GetRatingForIdentification(long id);
	}
}
