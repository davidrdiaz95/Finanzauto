using School_Finanzauto.Model.Section;

namespace School_Finanzauto.Extensions
{
	public static class MapSectionConfigServicesExtension
	{
		public static void ConfigureMapSectionConfiguration(this IServiceCollection services, IConfiguration configuration)
		{
			IConfigurationSection configuracionFocos = configuration.GetSection("TokenConfiguration");
			services.Configure<TokenConfiguration>(configuracionFocos);
		}
	}
}
