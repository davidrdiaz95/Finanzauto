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
	public class RatingController : ControllerBase
	{
		private readonly IRatingService ratingService;

		public RatingController(IRatingService ratingService)
		{
			this.ratingService = ratingService;
		}

		[HttpPost]
		public async Task<IActionResult> CretateRating(RatingDto rating)
		{
			var result = await this.ratingService.CreateRating(rating);
			if (result.StatusCode.Equals(HttpStatusCode.OK))
				return Ok(result);
			else 
				return BadRequest(result);
		}
	}
}
