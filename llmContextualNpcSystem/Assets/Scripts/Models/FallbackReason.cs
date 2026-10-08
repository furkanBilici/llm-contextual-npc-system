namespace LlmContextualNpc.Models
{
    public enum FallbackReason
    {
        ApiUnavailable = 0,
        InvalidJson = 1,
        ValidationFailed = 2,
        StaleResponse = 3
    }
}
