using System;

namespace Csn.Public.Dto
{
    public class Registration
    {
        public string State { get; set; }
        public string Number { get; set; }
        public DateTime? ExpiresUtc { get; set; }
        public DateTime? FirstRegisteredUtc { get; set; }
        public int? OwnerCount { get; set; }
    }
}
