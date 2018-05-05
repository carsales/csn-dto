using System;
using System.Collections.Generic;
using Csn.Public.Dto.Misc;
using Csn.Public.Dto.Vehicle;

namespace Csn.Public.Dto.Lead
{
    public class LeadVehicle
    {
        public string Type { get; set; }            // CAR, BIKE, BOAT, TRUCK, CARAVAN etc
        public Guid? Identifier { get; set; }
        public string StockNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Badge { get; set; }
        public string Series { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public Price Price { get; set; }
        public string PriceType { get; set; }

        public VehicleRegistration Registration { get; set; }
        public string EngineDescription { get; set; }
        public List<SimpleColour> Colour { get; set; }

        public List<TypeValue> IdentificationNumbers { get; set; }
        public string BodyType { get; set; }
        public SimpleValue Odometer { get; set; }
        public string FuelType { get; set; }
        public string Url { get; set; }
        public string Transmission { get; set; }

        public string CategoryType { get; set; }
        public string Group { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
    }
}