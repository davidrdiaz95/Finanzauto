using School_Finanzauto.Middlewares;

namespace School_Finanzauto.Extensions
{
	public static class ExtencionServicioErrores
	{
		public static void UseErrorHanldinMiddleware(this IApplicationBuilder app)
		{
			app.UseMiddleware<ErrorHandlerMiddleware>(Array.Empty<object>());
		}
	}
}
