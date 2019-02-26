using System;
using System.Collections.Generic;

namespace Csn.Public.Dto
{
    public class Licence
    {
        public Guid Identifier { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Address Address { get; set; }
        public SimpleDate DateOfBirth { get; set; }

        public string LicenceNumber { get; set; }
        public DateTime LicenceExpiry { get; set; }

        /* CAR, LEARNER, MOTORCYCLE etc. */
        public string LicenceType { get; set; }
        public List<LicenceCondition> LicenceConditions { get; set; }
        public string LicenceSignatureImageUrl { get; set; }
    }

    public class LicenceCondition
    {
        // Using Victorian Licence Conditions as Sample: 
        // A - automatic transmission
        // B - synchromesh transmission - heavy vehicle only
        // E - LAMS restriction, no pillion passenger and zero BAC
        // I - ignition interlock device
        // N - automatic transmission(motorcycle)
        // P - passenger restriction
        // S - glasses or corrective lenses
        // V - driver aids or vehicle modifications
        // X - any condition or restriction VicRoads has advised you of in writing
        // Z - zero blood alcohol limit

        public Guid Identifier { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
    }
}
