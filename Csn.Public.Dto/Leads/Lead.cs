using Csn.Public.Dto.Customers;
using Csn.Public.Dto.Vehicles;
using System;
using System.Collections.Generic;

namespace Csn.Public.Dto.Leads
{
    public class Lead
    {
        public Lead()
        {
            Prospect = new Customer();
            Environment = new Environment();
        }

        /* required */
        public Guid Identifier { get; set; }
        
        /* ISO Short two char country codes, e.g. AU, NZ, US etc. */
        public string CountryCode { get; set; }
        public Customer Seller { get; set; }

        /* name of the sender of the lead */
        public string Source { get; set; }

        /* Type = [USED, NEW, DEMO, GENERAL, GENERIC, SHOWROOM, SERVICE, FINANCE, INSURANCE]*/
        public string Type { get; set; }

        /* Status = [New, Contact, Commitment, Sold, Lost, Duplicate, Unworkable] */
        public string Status { get; set; }  
        
        public Environment Environment { get; set; }
        public Customer Prospect { get; set; }

        public string Comments { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime? ModifiedUtc { get; set; }

        public List<TypeValue> Labels { get; set; }
        public CallConnect CallConnect { get; set; }

        public Vehicle Item { get; set; }
        public Vehicle TradeIn { get; set; }

        /* ServiceRequests = [Finance, Insurance] */
        public List<TypeValue> ServiceRequests { get; set; }

        public List<HistoryItem> History { get; set; }
        public Assignment Assignment { get; set; }
        public List<NameValue> ExtendedProperties { get; set; }

        /* Subscriptions = [Newsletter, ConfirmResponse, Surveys] */
        public List<TypeValue> Subscriptions { get; set; }
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
        public string ReferrerUrl { get; set; }
        public string IpAddress { get; set; }
        public string SessionId { get; set; }
    }

    public class ContactRequest
    {
        public string Method { get; set; }
        public string Time { get; set; }
    }
}
