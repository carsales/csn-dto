using System;
using System.Collections.Generic;

namespace Csn.Public.Dto
{
    public class User
    {
        public Guid Identifier { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
        public string EmailAddress { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
        public List<ApplicationClaims> ApplicationClaims { get; set; }
    }

    public class ApplicationClaims
    {
        public string ApplicationName { get; set; }
        public List<string> Claims { get; set; }
    }
}