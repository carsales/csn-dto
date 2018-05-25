using System;

namespace Csn.Public.Dto
{
    public class Registration
    {
        public string State { get; set; }
        public string Number { get; set; }
        public DateTime ExpiresUTC { get; set; }
        public DateTime FirstRegisteredUTC { get; set; }
        public int? OwnerCount { get; set; }
    }
}