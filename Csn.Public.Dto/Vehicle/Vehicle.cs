﻿using System;
using System.Collections.Generic;

namespace Csn.Public.Dto
{
    public class Vehicle
    {
        public Vehicle()
        {
            Specification = new Specification();
            Seller = new Customer();
            ComplianceDate = new SimpleDate();
            BuildDate = new SimpleDate();
            Warranty = new Warranty();
            Identification = new List<TypeValue>();
            Registration = new Registration();
            OdometerReadings = new List<OdometerReading>();
        }

        public Guid Identifier { get; set; }

        /* ListingType = [New, Demo, Used] */
        public string ListingType { get; set; }

        /* SaleStatus = [Available, WithDrawn, Sold] */ 
        public string SaleStatus { get; set; }

        /* SaleType = [Sale, Share, Rent, Auction] */
        public string SaleType { get; set; }

        public string Comment { get; set; }

        public Registration Registration { get; set; }

        /* Identification Numbers = [HIN, VIN, Engine, Chassis, StockNumber] */
        public List<TypeValue> Identification { get; set; }

        public List<SimpleColour> Colours { get; set; }

        public List<OdometerReading> OdometerReadings { get; set; }
        public Customer Seller { get; set; }

        public Specification Specification { get; set; }
        public GeoLocation GeoLocation { get; set; }
        public Media Media { get; set; }

        public string Group { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }

        public SimpleDate ComplianceDate { get; set; }
        public SimpleDate BuildDate { get; set; }
        public Warranty Warranty { get; set; }

        public List<SimpleName> PublishingDestinations { get; set; }
        public List<NameValue> Tags { get; set; }
        public List<Price> PriceList { get; set; }
        public List<NameValue> ExtendedProperties { get; set; }
        public List<TypeName> Certifications { get; set; }
    }

    public class OdometerReading
    {
        /* Type = [Chassis, Hub, Engine, Engine_1, Engine_2] */
        public string Type { get; set; }
        public DateTime? Date { get; set; }
        public double? Value { get; set; }

        /* UnitOfMeasure = [Km, Hour, Miles] */
        public string UnitOfMeasure { get; set; }
    }
}
