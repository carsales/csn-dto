using System;
using System.Collections.Generic;
using Csn.Public.Dto.Vehicle;

namespace Csn.Public.Dto.Lead
{
    public class LeadVehicle
    {
        /* Type = [CAR, BIKE, BOAT, TRUCK, CARAVAN etc] */
        public string Type { get; set; }
        public Guid? Identifier { get; set; }
        public string StockNumber { get; set; }
        public string Url { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Badge { get; set; }
        public string Series { get; set; }
        public string Description { get; set; }
        public SimpleDate ReleaseDate { get; set; }
        public Price Price { get; set; }

        public Registration Registration { get; set; }
        public List<SimpleColour> Colour { get; set; }

        public List<TypeValue> IdentificationNumbers { get; set; }
        public SimpleValue<double> Odometer { get; set; }

        public string BodyType { get; set; }
        public string FuelType { get; set; }
        public string Transmission { get; set; }
        public string Engine { get; set; }

        public string CategoryType { get; set; }
        public string Group { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
    }
}