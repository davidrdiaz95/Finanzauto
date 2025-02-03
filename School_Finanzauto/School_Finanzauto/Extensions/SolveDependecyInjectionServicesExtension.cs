using NetCore.AutoRegisterDi;
using School_Finanzauto.BusinessServices.Mapper;
using School_Finanzauto.Model.Dto;
using School_Finanzauto.Repository.Entity;
using School_Finanzauto.Repository.Repository.Interface;
using School_Finanzauto.Repository.Repository.Service;
using School_Finanzauto.Services.Mapper;
using System.Reflection;

namespace School_Finanzauto.Extensions
{
	public static class SolveDependecyInjectionServicesExtension
	{
		public static void ConfigureDependencyInjection(this IServiceCollection services)
		{
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddScoped(typeof(IMapper<Teachers, TeacherDto>), typeof(TeacherMapper));
			services.AddScoped(typeof(IMapper<Repository.Entity.Course, CoursesDto>), typeof(CoursesMapper));
			services.AddScoped(typeof(IMapper<Students, StudentsDto>), typeof(StudentsMapper));
			services.AddScoped(typeof(IMapper<Ratings, RatingDto>), typeof(RatingsMapper));

			Assembly assemblyServicesInterface = AppDomain.CurrentDomain.Load("School_Finanzauto.Services");
			Assembly assemblyServicesImplementation = AppDomain.CurrentDomain.Load("School_Finanzauto.BusinessServices");
			Assembly assemblyDataInterface = AppDomain.CurrentDomain.Load("School_Finanzauto.Repository");
			Assembly assemblyDataImplementation = AppDomain.CurrentDomain.Load("School_Finanzauto.Repository");

			services.RegisterAssemblyPublicNonGenericClasses(new Assembly[] { assemblyServicesInterface, assemblyServicesImplementation })
				.Where(c => c.Name.EndsWith("Command"))
				.AsPublicImplementedInterfaces();

			services.RegisterAssemblyPublicNonGenericClasses(new Assembly[] { assemblyServicesInterface, assemblyServicesImplementation })
				.Where(c => c.Name.EndsWith("Invoker"))
				.AsPublicImplementedInterfaces();

			services.RegisterAssemblyPublicNonGenericClasses(new Assembly[] { assemblyServicesInterface, assemblyServicesImplementation })
				.Where(c => c.Name.EndsWith("Service"))
				.AsPublicImplementedInterfaces();

			services.RegisterAssemblyPublicNonGenericClasses(new Assembly[] { assemblyServicesInterface, assemblyServicesImplementation })
				.Where(c => c.Name.EndsWith("Mapper"))
				.AsPublicImplementedInterfaces();

		}
	}
}
