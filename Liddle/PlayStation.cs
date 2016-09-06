using System;
namespace Liddle
{
	public class PlayStation
	{
		public string Name { get; set; }

		public GeoLocation Location { get; set; }
	}

	public class GeoLocation { 
		public double Lat { get; set; }
		public double Lng { get; set; }
	}
}

