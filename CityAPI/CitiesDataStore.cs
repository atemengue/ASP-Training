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
					Id = 3,
					Name = "Yaounde",
					Description = "La capitale politique du cameroun",
					PointofInterest = new List<PointOfInterestDto>()
					{
						new PointOfInterestDto()
						{
							Id = 5,
							Name = "Palais des sports",
							Description = "Grand etablissement sportif construit par les chinos"
						},
						new PointOfInterestDto()
						{
							Id = 6,
							Name = "The louvre",
							Description = "The world's largest museum"
						}
					}
				}
			};
		}
	}
}

