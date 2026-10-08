namespace LlmContextualNpc.Models
{
    public readonly struct ActionValidationResult
    {
        public ActionValidationResult(bool isValid, LlmActionResponse response, string failureReason)
        {
            IsValid = isValid;
            Response = response;
            FailureReason = failureReason ?? string.Empty;
        }

        public bool IsValid { get; }

        public LlmActionResponse Response { get; }

        public string FailureReason { get; }

        public static ActionValidationResult Valid(LlmActionResponse response)
        {
            return new ActionValidationResult(true, response, string.Empty);
        }

        public static ActionValidationResult Invalid(string failureReason)
        {
            return new ActionValidationResult(false, null, failureReason);
        }
    }
}
