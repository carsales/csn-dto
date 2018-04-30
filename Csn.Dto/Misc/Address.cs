using System.Collections.Generic;

namespace Csn.Dto.Misc
{
    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }

        public string Region { get; set; }
        public string Postcode { get; set; }

        public string Country { get; set; }
        public string CountryCode { get; set; }
    }

    public class Location
    {
        public string State { get; set; }
        public List<string> Regions { get; set; }
    }

    public class GeoLocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
