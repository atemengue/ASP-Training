using CityAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityAPI.Controllers
{
	[ApiController]
	[Route("api/cities")]
	public class CitiesController: ControllerBase
	{
		//[HttpGet("api/cities")]
		[HttpGet]
		public ActionResult<IEnumerable<CityDto>> GetCities()
		{
			return Ok(CitiesDataStore.Current);
		}

		//HttpGet("{id}")]
		//public JsonResult GetCity(int id)
		//{
		//	return new JsonResult(
		//	CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
		//}
		[HttpGet("{id}")]
		public ActionResult<CityDto> GetCity(int id)
		{
			var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
			if (cityToReturn == null)
				return NotFound();
			return Ok(cityToReturn);
		}
    }
};

