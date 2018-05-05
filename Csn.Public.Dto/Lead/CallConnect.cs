using System;

namespace Csn.Public.Dto.Lead
{
    public class CallConnect
    {
        public Guid? Identifier { get; set; }
        public string CallId { get; set; }

        public DateTime CreatedUtc { get; set; }
        public DateTime CallStartUtc { get; set; }
        public DateTime CallEndUtc { get; set; }

        /* the number called */
        public string ServiceNumber { get; set; }

        /* the number the call was diverted to */
        public string AnswerNumber { get; set; }
        public string CallDuration { get; set; }
        public string AnswerDuration { get; set; }
        public string CallOutcome { get; set; }
        public string TransferOutcome { get; set; }
        public string CallOutcomeText { get; set; }

        public string VoiceMailUrl { get; set; }
        public string CallRecordingUrl { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public bool HideRecording { get; set; }

        public string Code { get; set; }
    }
}