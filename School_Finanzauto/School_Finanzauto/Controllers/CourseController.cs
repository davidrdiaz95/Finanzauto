using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using School_Finanzauto.Model.Dto;
using School_Finanzauto.Services.Service;
using System.Net;

namespace School_Finanzauto.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize(Roles = "Teacher")]
	public class CourseController : ControllerBase
	{
		private readonly ICourseService courseService;

		public CourseController(ICourseService courseService)
		{
			this.courseService = courseService;
		}

		[HttpPost]
		[Route("CreateCourse")]
		public async Task<IActionResult> CreateCourse(CoursesDto courses)
		{
			var result = await this.courseService.CreateCourse(courses);
			if (result.StatusCode.Equals(HttpStatusCode.OK)) 
				return Ok(result);
			else 
				return BadRequest(result);
		}

		[HttpGet]
		[Route("GetAll")]
		public async Task<IActionResult> GetAll()
		{
			var result = await this.courseService.GetAll();
			if (result.StatusCode.Equals(HttpStatusCode.OK))
				return Ok(result);
			else
				return BadRequest(result);
		}
	}
}
