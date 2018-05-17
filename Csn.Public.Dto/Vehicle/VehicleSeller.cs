using System;
using System.Collections.Generic;
using Csn.Public.Dto.Misc;

namespace Csn.Public.Dto.Vehicle
{
    public class VehicleSeller
    {
        public Guid Identifier { get; set; }
        public string Type { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public List<Address> Addresses { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }

        /* Identification = [ABN, LMCT, ACN etc] */
        public List<TypeValue> Identification { get; set; }
        public List<Location> Locations { get; set; }
        public GeoLocation GeoLocation { get; set; }
        public List<SellerContact> Contacts { get; set; }

        public List<NameValue> Franchises { get; set; }
        public List<NameValue> Services { get; set; }

        public string Url { get; set; }

        public List<NameValue> Associations { get; set; }
    }

    public class SellerContact
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
        public string Email { get; set; }
    }

    public class PhoneNumber
    {
        public string Type { get; set; }
        public string Number { get; set; }
        /* international calling code for a country, e.g. 61 for AU, 64 for NZ. */
        public int CountryCode { get; set; }
        public int AreaCode { get; set; }
    }
}
