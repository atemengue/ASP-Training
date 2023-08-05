
using CityAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityAPI.Controllers
{
	[Route("api/cities/{cityId}/pointsofinterest")]
	public class PointsOfInterestController: ControllerBase
	{
		[HttpGet]
		public ActionResult<IEnumerable<PointOfInterestDto>> GetPointsOfIntereset(int cityId)
		{
			var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
			if (city == null)
				return NotFound();

			return Ok(city.PointofInterest);
		}
		[HttpGet("{pointofinteresetid}")]
		public ActionResult<PointOfInterestDto> GetPointOfInterest(int cityId, int pointOfInterestId)
		{
			// find city
			var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
			if (city == null)
				return NotFound();

			// find point of interest
			var pointOfInterest = city.PointofInterest.FirstOrDefault(p => p.Id == pointOfInterestId);
			if (pointOfInterest == null)
				return NotFound();

			return Ok(pointOfInterest);
		}
	}
}

