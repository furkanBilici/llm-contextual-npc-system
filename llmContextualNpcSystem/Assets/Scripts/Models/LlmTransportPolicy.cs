using System;

namespace LlmContextualNpc.Models
{
    /// <summary>
    /// Timeout and bounded retry for one LLM request. Zero retries means a single attempt.
    /// </summary>
    public readonly struct LlmTransportPolicy
    {
        public LlmTransportPolicy(TimeSpan timeout, int maxRetries)
        {
            Timeout = timeout < TimeSpan.Zero ? TimeSpan.Zero : timeout;
            MaxRetries = maxRetries < 0 ? 0 : maxRetries;
        }

        public TimeSpan Timeout { get; }

        public int MaxRetries { get; }
    }
}
