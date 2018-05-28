using System;

namespace Csn.Public.Dto
{
    public class TelephoneCall
    {
        public Guid? Identifier { get; set; }
        public string Id { get; set; }

        public DateTime CreatedUtc { get; set; }
        public DateTime StartUtc { get; set; }
        public DateTime EndUtc { get; set; }

        /* the calling number (or null/Private if not exposed) */
        public string OriginatingNumber { get; set; }

        /* the number called */
        public string ServiceNumber { get; set; }

        /* the number the call was diverted to */
        public string AnswerNumber { get; set; }

        public string Duration { get; set; }
        public string AnswerDuration { get; set; }
        public string Outcome { get; set; }
        public string TransferOutcome { get; set; }
        public string OutcomeDescription { get; set; }

        public CallRecording VoiceMail { get; set; }
        public CallRecording Recording { get; set; }

        public string Code { get; set; }
    }

    public class CallRecording 
    {
        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Hidden { get; set; }
    }
}
