using System;
using System.Collections.Generic;
using Csn.Public.Dto.Misc;

namespace Csn.Public.Dto.Vehicle
{
    public class VehicleSpecification
    {
        public Guid Identifier { get; set; }

        /* The source. Redbook, Glasses, JATO etc. including CUSTOM */
        public string SpecificationSource { get; set; }
        /* the code from the specification source, this would be a redbook code, glasses code, jato, polk etc */
        public string SpecificationCode { get; set; }

        /* ISO Short two char country codes, e.g. AU, NZ, US etc. */
        public string CountryCode { get; set; }

        /* RecordType = [Car, Bike, MarineSail, MarineEngine, MarinePower, LightCommercial, HeavyCommercial] */
        public string RecordType { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Series { get; set; }
        public SimpleDate ReleaseDate { get; set; }

        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Description { get; set; }
        public string Franchise { get; set; }

        public List<SpecificationAttribute> Attributes { get; set; }
        public List<SpecificationFeature> Features { get; set; }
    }

    public class SpecificationAttribute
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Group { get; set; }

        public string Value { get; set; }
        public string Units { get; set; }
    }

    public class SpecificationFeature : SpecificationAttribute
    {
        /* Availability = [STD, OPT, AFM] */
        public string Availability { get; set; }

        public List<SpecificationFeature> SubFeatures { get; set; }
    }
}
