using Microsoft.AspNetCore.Mvc;

namespace CityAPI.Controllers
{
	[ApiController]
	[Route("api/cities")]
	public class CitiesController: ControllerBase
	{
		//[HttpGet("api/cities")]   
		public JsonResult GetCities()
		{
			return new JsonResult(
				new List<object> {
					new { id = 1, Name = "Yaounde"},
					new { id = 2, Name = "Douala"}
				});
			}

    
    }
}

