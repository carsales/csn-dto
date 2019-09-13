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
        public List<ApplicationRole> ApplicationRoles { get; set; }
    }

    public class ApplicationRole
    {
        public Application Application { get; set; }
        public Role Role { get; set; }
        public CustomerItem Customer { get; set; }
    }

    public class Application
    {
        public string Name { get; set; }
    }

    public class Role
    {
        public string Name { get; set; }
    }

    public class CustomerItem
    {
        public Guid Identifier { get; set; }
    }
}