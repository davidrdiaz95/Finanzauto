namespace School_Finanzauto.Model.Dto
{
	public class StudentsDto
	{
		public long Identification { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string UserLogin { get; set; }
		public string PasswordLogin { get; set; }
		public int FkIdCourse { get; set; }
		public int IdUserCreate { get; set; }
	}
}
