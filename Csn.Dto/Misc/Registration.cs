using System;

namespace Csn.Dto.Misc
{
    public class Registration
    {
        public string State { get; set; }
        public string Number { get; set; }
        public DateTime Expires { get; set; }
        public DateTime FirstRegistered { get; set; }
        public int? OwnerCount { get; set; }
    }
}