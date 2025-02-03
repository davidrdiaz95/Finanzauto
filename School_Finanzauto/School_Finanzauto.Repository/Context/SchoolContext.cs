using Microsoft.EntityFrameworkCore;
using School_Finanzauto.Repository.Configuration;
using School_Finanzauto.Repository.Entity;

namespace School_Finanzauto.Repository.Context
{
	public class SchoolContext : DbContext
	{
		public DbSet<Course> Course { get; set; }
		public DbSet<Ratings> Ratings { get; set; }
		public DbSet<Students> Students { get; set; }
		public DbSet<Teachers> Teachers { get; set; }

		public SchoolContext(DbContextOptions options) : base(options)
		{
		}

		public SchoolContext()
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new TeachersEntityConfiguration());
			modelBuilder.ApplyConfiguration(new StudentsEntityConfiguration());
			modelBuilder.ApplyConfiguration(new RatingsEntityConfiguration());
			modelBuilder.ApplyConfiguration(new CoursesEntityConfiguration());
		}
	}
}
