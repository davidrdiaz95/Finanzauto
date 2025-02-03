namespace School_Finanzauto.Repository.Entity.Base
{
	public class BaseEntity
	{
		public int Id { get; set; }
		public DateTime DateCreate { get; set; }
		public int? FkIdUserCreate { get; set; }
		public DateTime? DateUpdate { get; set; }
		public int? FkIdUserUpdate { get; set; }
		public bool State { get; set; }
	}
}
