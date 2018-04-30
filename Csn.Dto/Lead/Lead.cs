using System;
using System.Collections.Generic;
using Csn.Dto.Misc;

namespace Csn.Dto.Lead
{
    public class Lead
    {
        public Lead()
        {
            Prospect = new Prospect();
            TradeIn = new TradeInDetail();
            Environment = new Environment();
            Subscription = new ProspectSubscription();
        }

        public Guid Identifier { get; set; }

        public string CountryCode { get; set; }

        public Seller Seller { get; set; }
        public string Service { get; set; }         // Lead Service E.g. Carsales, 
        public string Type { get; set; }            // USED, NEW, DEMO, GENERAL, GENERIC, SHOWROOM, SERVICE, FINANCE, INSURANCE

        public string Status { get; set; }          // New, Contact, Commitment, Sold, Lost, Duplicate, and Unworkable  
        
        public Environment Environment { get; set; }
        public Prospect Prospect { get; set; }
        public ProspectSubscription Subscription { get; set; }
        public TradeInDetail TradeIn { get; set; }

        public string Comments { get; set; }
        public DateTime Created { get; set; }       // Use UTC time or provide TZ information with date.
        public DateTime? Modified { get; set; }     // Use UTC time or provide TZ information with date.

        public List<string> Tags { get; set; }
        public CallConnect CallConnect { get; set; }

        public LeadVehicle Item { get; set; }

        public List<HistoryItem> History { get; set; }
        public Assignment Assignment { get; set; }
        public List<NameValue> ExtendedProperties { get; set; }
    }

    public class Seller
    {
        public string Type { get; set; }            // DEALER or PRIVATE
        public Guid Identifier { get; set; }
        public string Name { get; set; }
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
        public DateTime Created { get; set; }       // UTC time or TZ info provided
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

        public Address Address { get; set; }
        public List<Phone> PhoneNumbers { get; set; }
        public ContactRequest ContactRequest { get; set; }
        public Guid Identifier { get; set; }
        public Guid TrackingIdentifier { get; set; }
        public List<TypeValue> IdentificationNumbers { get; set; }
    }

    public class ContactRequest
    {
        public string Method { get; set; }
        public string Time { get; set; }
    }

    public class Phone
    {
        public string Type { get; set; }
        public string Number { get; set; }
        public string CountryCode { get; set; }
    }

    public class ProspectSubscription
    {
        public bool Newsletter { get; set; }
        public bool FinanceQuote { get; set; }
        public bool InsuranceQuote { get; set; }
        public bool ConfirmResponse { get; set; }
        public bool Survey { get; set; }
    }
}
