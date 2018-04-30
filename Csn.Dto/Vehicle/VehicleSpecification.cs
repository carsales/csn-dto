using System;
using System.Collections.Generic;

namespace Csn.Dto.Vehicle
{
    public class VehicleSpecification
    {
        public Guid Identifier { get; set; }
        public string SpecificationSource { get; set; }
        public string SpecificationCode { get; set; }

        public string CountryCode { get; set; }
        public string RecordType { get; set; }

        public string Vertical { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string FamilyName { get; set; }
        public string Series { get; set; }

        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Description { get; set; }
        public string Franchise { get; set; }

        public int ReleaseYear { get; set; }
        public int ReleaseMonth { get; set; }
        public int MarketingYear { get; set; }
        public string ModelYear { get; set; }

        public List<SpecificationAttribute> Attributes { get; set; }
        public List<SpecificationFeature> Features { get; set; }

        public List<string> Usages { get; set; }
        public List<string> Lifestyles { get; set; }
        public List<string> UniqueCategories { get; set; }
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
        public string Availability { get; set; }
        public string Fitment { get; set; }

        public List<SpecificationFeature> SubFeatures { get; set; }
    }
}
