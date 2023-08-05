using System;
using CityAPI.Models;

namespace CityAPI
{
	public class CitiesDataStore
	{
		public List<CityDto> Cities { get; set;  }

		public static CitiesDataStore Current { get; } = new CitiesDataStore();
		public CitiesDataStore()
		{
			Cities = new List<CityDto>()
			{
				new CityDto()
				{
					Id = 1,
					Name = "New York City",
					Description = "The one with that big park"
				},
				new CityDto()
				{
					Id = 2,
					Name = "Douala Cameroun",
					Description = "la capitale economique du cameroun"
				},
				new CityDto()
				{
					Id = 1,
					Name = "Yaounde",
					Description = "La capitale politique du cameroun"
				}
			};
		}
	}
}

