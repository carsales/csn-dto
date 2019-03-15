using System;
using System.Collections.Generic;

namespace Csn.Public.Dto
{
    public class TestDrive
    {
        public Guid Identifier { get; set; }
        public Guid CustomerIdentifier { get; set; }
        public Guid LicenceIdentifier { get; set; }
        public Guid VehicleIdentifier { get; set; }
        public DateTime StartUtc { get; set; }
        public DateTime EndUtc { get; set; }
        public List<GeoTracking> GeoLocations { get; set; }
        public List<Infringement> Infringements { get; set; }
    }

    public class GeoTracking
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime TimeStampUtc { get; set; }
    }
}
