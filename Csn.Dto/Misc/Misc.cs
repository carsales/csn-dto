

namespace Csn.Dto.Misc
{
    public class NameValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class KeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class TypeValue
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class SimpleDate
    {
        public int? Day { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
    }

    public class SimpleValue
    {
        public double Value { get; set; }
        public string UnitOfMeasure { get; set; }
    }

    public class SimpleColour
    {
        public string Location { get; set; }            // Interior, Exterior, Bumber etc
        public string GenericName { get; set; }
        public string Name { get; set; }
    }

    public class Price
    {
        public string Type { get; set; }
        public string Location { get; set; }
        public string Currency { get; set; }
        public double? Amount { get; set; }
    }
}
