using School_Finanzauto.Repository.Entity.Base;

namespace School_Finanzauto.Repository.Entity
{
	public class Students : BaseEntity
	{
		public long Identification { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string UserLogin { get; set; }
		public string PasswordLogin { get; set; }
		public int FkIdCourse { get; set; }
		public IEnumerable<Ratings> Ratings { get; set; }
	}
}
