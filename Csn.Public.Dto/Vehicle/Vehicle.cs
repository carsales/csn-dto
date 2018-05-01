using System;
using System.Collections.Generic;
using Csn.Public.Dto.Misc;

namespace Csn.Public.Dto.Vehicle
{
    public class Vehicle
    {
        public Vehicle()
        {
            Specification = new VehicleSpecification();
            Seller = new VehicleSeller();
            ComplianceDate = new SimpleDate();
            BuildDate = new SimpleDate();
            Warranty = new VehicleWarranty();
            Identification = new List<TypeValue>();
            Registration = new Registration();
        }

        public Guid Identifier { get; set; }
        public string StockNumber { get; set; }

        public string ListingType { get; set; }
        public string SaleStatus { get; set; }
        public string SaleType { get; set; }

        public Registration Registration { get; set; }
        public List<TypeValue> Identification { get; set; }

        public List<SimpleColour> Colours { get; set; }

        public SimpleValue Odometer { get; set; }
        public bool? RoadWorthyCertificate { get; set; }
        public VehicleSeller Seller { get; set; }

        public VehicleSpecification Specification { get; set; }
        public GeoLocation GeoLocation { get; set; }
        public Media Media { get; set; }

        public string CategoryPath { get; set; }
        public string Group { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Segment { get; set; }

        public SimpleValue Length { get; set; }

        public SimpleDate ComplianceDate { get; set; }
        public SimpleDate BuildDate { get; set; }
        public VehicleWarranty Warranty { get; set; }

        public string CategoryType { get; set; }

        public string Comment { get; set; }
        public List<string> Services { get; set; }
        public List<NameValue> Tags { get; set; }
        public List<Price> PriceList { get; set; }
        public List<NameValue> ExtendedProperties { get; set; }
    }

    public class VehicleWarranty
    {
        public DateTime Expires { get; set; }
    }
}
