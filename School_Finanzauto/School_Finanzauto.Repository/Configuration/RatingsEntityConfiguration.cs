using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School_Finanzauto.Repository.Entity;

namespace School_Finanzauto.Repository.Configuration
{
	public class RatingsEntityConfiguration : IEntityTypeConfiguration<Ratings>
	{
		public void Configure(EntityTypeBuilder<Ratings> builder)
		{
			builder.ToTable("Ratings");
			builder.Property(x => x.Note).HasColumnName("Ratings");
			builder.Property(x => x.FkIdCourse).HasColumnName("Fk_id_courses");
			builder.Property(x => x.FkIdStudent).HasColumnName("Fk_id_students");

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
