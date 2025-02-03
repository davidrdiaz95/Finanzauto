using School_Finanzauto.Repository.Entity.Base;

namespace School_Finanzauto.Repository.Entity
{
	public class Teachers : BaseEntity
	{
		public long Identification { get; set; }
		public string Name { get; set; }
		public string UserLogin { get; set; }
		public string PasswordLogin { get; set; }
		public IEnumerable<Course> Courses { get; set; }
	}
}
