using Microsoft.AspNetCore.Mvc;
using School_Finanzauto.Model.Dto;
using School_Finanzauto.Services.Service;
using System.Net;

namespace School_Finanzauto.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentController : ControllerBase
	{
		private readonly IStudentService studentService;

		public StudentController(IStudentService studentService)
		{
			this.studentService = studentService;
		}

		[HttpPost]
		[Route("CreateStudent")]
		public async Task<IActionResult> Create(StudentsDto students)
		{
			var result = await studentService.CreateStudent(students);
			if (result.StatusCode.Equals(HttpStatusCode.OK))
				return Ok(result);
			else
				return BadRequest(result);
		}

		[HttpPut]
		[Route("UpdateStudent")]
		public async Task<IActionResult> Update(StudentsUpdateDto students)
		{
			var result = await studentService.UpdateStudent(students);
			if (result.StatusCode.Equals(HttpStatusCode.OK))
				return Ok(result);
			else
				return BadRequest(result);
		}

		[HttpGet]
		[Route("GetFinByIdentification")]
		public async Task<IActionResult> GetFinByIdentification(long id)
		{
			var result = await studentService.GetFinByIdentification(id);
			if (result.StatusCode.Equals(HttpStatusCode.OK))
				return Ok(result);
			else
				return BadRequest(result);
		}

		[HttpGet]
		[Route("GetReatingFinByIdentification")]
		public async Task<IActionResult> GetFinByIdentification(int id)
		{
			var result = await studentService.GetRatingForIdentification(id);
			if (result.StatusCode.Equals(HttpStatusCode.OK))
				return Ok(result);
			else
				return BadRequest(result);
		}

		[HttpDelete]
		[Route("DeleteFinByIdentification")]
		public async Task<IActionResult> DeleteFinByIdentification(long id)
		{
			var result = await studentService.DeleteFinByIdentification(id);
			if (result.StatusCode.Equals(HttpStatusCode.OK))
				return Ok(result);
			else
				return BadRequest(result);
		}
	}
}
