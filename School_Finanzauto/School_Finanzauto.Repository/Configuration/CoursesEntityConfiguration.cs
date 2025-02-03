using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School_Finanzauto.Repository.Entity;

namespace School_Finanzauto.Repository.Configuration
{
	public class CoursesEntityConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.ToTable("Courses");

			builder.Property(x => x.Name).HasColumnName("Name");
			builder.Property(x => x.TeachersId).HasColumnName("TeachersId");

			builder.Property(x => x.Id).HasColumnName("Id");
			builder.Property(x => x.DateCreate).HasColumnName("Date_create");
			builder.Property(x => x.FkIdUserCreate).HasColumnName("Fk_id_user_create");
			builder.Property(x => x.DateUpdate).HasColumnName("Date_update");
			builder.Property(x => x.FkIdUserUpdate).HasColumnName("Fk_id_user_update");
			builder.Property(x => x.State).HasColumnName("State");
			builder.HasKey(x => x.Id);
		}
	}
}
