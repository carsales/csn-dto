using System;

namespace Csn.Public.Dto
{
    public class Infringement
    {
        public Guid Identifier { get; set; }
        public Guid? TestDriveIdentifier { get; set; }
        public string InfringementNumber { get; set; }
        public double InfringementPenalty { get; set; }
        public DateTime InfringementDueUtc { get; set; }
        public double DemeritPoints { get; set; }
        public DateTime OffenceUtc { get; set; }
        public string OffenceRegistration { get; set; }
        public string OffenceDescription { get; set; }
    }
}
