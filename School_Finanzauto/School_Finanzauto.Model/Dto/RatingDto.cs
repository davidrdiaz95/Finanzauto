namespace School_Finanzauto.Model.Dto
{
	public class RatingDto
	{
		public decimal Note { get; set; }
		public int FkIdCourse { get; set; }
		public int FkIdStudent { get; set; }
		public int FkIdTeacher { get; set; }
	}
}
