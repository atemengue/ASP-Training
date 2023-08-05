using Microsoft.AspNetCore.Mvc;

namespace CityAPI.Controllers
{
	[ApiController]
	[Route("api/cities")]
	public class CitiesController: ControllerBase
	{
		//[HttpGet("api/cities")]
		[HttpGet]
		public JsonResult GetCities()
		{
			return new JsonResult(CitiesDataStore.Current);
		}

		[HttpGet("{id}")]
		public JsonResult GetCity(int id)
		{
			return new JsonResult(
			CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
		}
    }
};

