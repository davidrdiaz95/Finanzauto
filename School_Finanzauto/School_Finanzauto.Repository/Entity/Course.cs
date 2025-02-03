using School_Finanzauto.Repository.Entity.Base;

namespace School_Finanzauto.Repository.Entity
{
	public class Course : BaseEntity
	{
		public string Name { get; set; }
		public int TeachersId { get; set; }
	}
}
