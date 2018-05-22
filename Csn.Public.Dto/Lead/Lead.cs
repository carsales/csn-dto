using System;
using System.Collections.Generic;

namespace Csn.Public.Dto.Lead
{
    public class Lead
    {
        public Lead()
        {
            Prospect = new Prospect();
            Environment = new Environment();
        }

        /* required */
        public Guid Identifier { get; set; }
        /* ISO Short two char country codes, e.g. AU, NZ, US etc. */
        public string CountryCode { get; set; }
        public Seller Seller { get; set; }

        /* name of the sender of the lead */
        public string Service { get; set; }

        /* Type = [USED, NEW, DEMO, GENERAL, GENERIC, SHOWROOM, SERVICE, FINANCE, INSURANCE]*/
        public string Type { get; set; }

        /* Status = [New, Contact, Commitment, Sold, Lost, Duplicate, Unworkable] */
        public string Status { get; set; }  
        
        public Environment Environment { get; set; }
        public Prospect Prospect { get; set; }

        public string Comments { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime? ModifiedUtc { get; set; }

        public List<TypeValue> Tags { get; set; }
        public CallConnect CallConnect { get; set; }

        public LeadVehicle Item { get; set; }
        public LeadVehicle TradeIn { get; set; }

        public List<HistoryItem> History { get; set; }
        public Assignment Assignment { get; set; }
        public List<NameValue> ExtendedProperties { get; set; }
    }

    /* subset of the Customer Class */
    public class Seller
    {
        /* Type = [DEALER, PRIVATE] */
        public string Type { get; set; }
        public Guid Identifier { get; set; }
        public string Name { get; set; }

        /* IdentityNumbers = [ABN, ACN etc] */
        public List<TypeValue> IdentityNumbers { get; set; }
    }

    public class Assignment
    {
        public Guid? Identifier { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime Assigned { get; set; }
    }

    public class HistoryItem
    {
        public Guid? Identifier { get; set; }
        public string Type { get; set; }
        public DateTime CreatedUtc { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Environment
    {
        public string Source { get; set; }
        public string Url { get; set; }
        public string IpAddress { get; set; }
        public string SessionId { get; set; }
    }

    public class Prospect
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }

        public List<Address> Addresses { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
        public ContactRequest ContactRequest { get; set; }
        public Guid? Identifier { get; set; }
        public List<TypeValue> IdentificationNumbers { get; set; }
        public List<TypeValue> Subscriptions { get; set; }
    }

    public class ContactRequest
    {
        public string Method { get; set; }
        public string Time { get; set; }
    }
}
