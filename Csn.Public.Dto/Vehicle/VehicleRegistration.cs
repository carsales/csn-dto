using System;

namespace Csn.Public.Dto.Vehicle
{
    public class VehicleRegistration
    {
        public string State { get; set; }
        public string Number { get; set; }
        public DateTime Expires { get; set; }
        public DateTime FirstRegistered { get; set; }
        public int? OwnerCount { get; set; }
    }
}