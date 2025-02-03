using Microsoft.EntityFrameworkCore;
using School_Finanzauto.Repository.Context;

namespace School_Finanzauto.Extensions
{
	public static class RepositoryServicesExtension
	{
		public static void ConfigureDataBaseConnection(this IServiceCollection services, string connectionString)
		{
			services.AddDbContext<SchoolContext>(options =>
			{
				options.UseSqlServer(connectionString);
			});
		}
	}
}
