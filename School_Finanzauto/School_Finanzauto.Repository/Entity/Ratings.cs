using School_Finanzauto.Repository.Entity.Base;

namespace School_Finanzauto.Repository.Entity
{
	public class Ratings : BaseEntity
	{
		public decimal Note { get; set; }
		public int FkIdCourse { get; set; }
		public int FkIdStudent { get; set; }
		public Students Student { get; set; }
	}
}
