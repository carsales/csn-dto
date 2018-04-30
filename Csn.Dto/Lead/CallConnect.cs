using System;

namespace Csn.Dto.Lead
{
    public class CallConnect
    {
        public string CallId { get; set; }

        public DateTime DateCreatedUtc { get; set; }
        public DateTime CallStartUtc { get; set; }
        public DateTime CallEndUtc { get; set; }

        public string ServiceNumber { get; set; }
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