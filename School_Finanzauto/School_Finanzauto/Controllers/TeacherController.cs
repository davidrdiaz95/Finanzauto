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
	public class TeacherController : ControllerBase
	{
		private readonly ITeacherService teacherService;

		public TeacherController(ITeacherService teacherService)
		{
			this.teacherService = teacherService;
		}

		[Route("CreateTeacher")]
		[HttpPost]
		public async Task<IActionResult> Create(TeacherDto teacherDto)
		{
			var response = await this.teacherService.CreateTechaer(teacherDto);
			if (response.StatusCode.Equals(HttpStatusCode.OK))
				return Ok(response);
			else
				return BadRequest(response);
		}

		[Route("UpdateTeacher")]
		[HttpPut]
		public async Task<IActionResult> Update(TeacherUpdateDto teacherDto)
		{
			var response = await this.teacherService.UpdateTechaer(teacherDto);
			if (response.StatusCode.Equals(HttpStatusCode.OK))
				return Ok(response);
			else
				return BadRequest(response);
		}

		[Route("GetFinByIdentification")]
		[HttpGet]
		public async Task<IActionResult> GetFinByIdentification(long id)
		{
			var response = await this.teacherService.GetFinByIdentification(id);
			if (response.StatusCode.Equals(HttpStatusCode.OK))
				return Ok(response);
			else
				return BadRequest(response);
		}
	}
}
