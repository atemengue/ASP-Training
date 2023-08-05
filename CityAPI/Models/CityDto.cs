using System;
namespace CityAPI.Models
{
	public class CityDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string? Description { get; set; }
		public ICollection<PointOfInterestDto> PointofInterest { get; set; } = new List<PointOfInterestDto>();
		public int NumberOfPointOfInterest
		{
			get
			{
				return PointofInterest.Count;
			}
		}
	}
}

