namespace School_Finanzauto.Model.Dto
{
	public class StudentsUpdateDto
	{
		public int Id { get; set; }
		public long Identification { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string UserLogin { get; set; }
		public string PasswordLogin { get; set; }
		public int FkIdCourse { get; set; }
		public int IdUserUpdate { get; set; }
		public bool State { get; set; }
	}
}
