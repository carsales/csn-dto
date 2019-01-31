using System;
using System.Collections.Generic;

namespace Csn.Public.Dto
{
    public class Customer
    {
        public Guid Identifier { get; set; }

        /* Guid for the organisation that owns this customer */
        public Guid? OwnerIdentifier { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public List<Address> Addresses { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }

        /* Identification = [ABN, LMCT, ACN etc] */
        public List<TypeValue> Identification { get; set; }
        public List<Location> Locations { get; set; }
        public GeoLocation GeoLocation { get; set; }
        
        /* TimeZone = tz standard https://www.iana.org/time-zones as used in nodatime.org*/
        public string TimeZone { get; set; }
        public List<Contact> Contacts { get; set; }

        public List<NameValue> Products { get; set; }

        public string Url { get; set; }

        public List<TypeValue> Subscriptions { get; set; }
        public List<Period> OperatingHours { get; set; }
        public List<NameValue> Configuration { get; set; }
    }

    public class Contact
    {
        /* Type = [Primary, Secondary] */
        public string Type { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
        public string Email { get; set; }
    }

    public class PhoneNumber
    {
        /* Type = [Mobile, Home, Fax, Work] */
        public string Type { get; set; }
        public string Number { get; set; }
        /* international calling code for a country, e.g. 61 for AU, 64 for NZ. */
        public int CountryCode { get; set; }
        public int AreaCode { get; set; }
    }

    public class Period
    {
        /* Day = [WeekDays, Weekend, Public Holidays, Monday, New Years Day, Good Friday... etc] */
        public string Day { get; set; }
        /* Date = [Special Days e.g. "New Years Day" simply set Day and Month, otherwise set the full date] */
        public SimpleDate Date { get; set; }
        public TimeOfDay Open { get; set; }
        public TimeOfDay Close { get; set; }
        /* Comments = ["By appointment only", "New Years Day", etc.] */
        public string Comments { get; set; }
    }

    public class TimeOfDay 
    {
        /* Time = 24 hour time notation for hours, e.g. 16 for 4pm */
        public byte Hour { get; set; }
        public byte Minute { get; set; }
        public bool AllDay { get; set; }
    }

}
