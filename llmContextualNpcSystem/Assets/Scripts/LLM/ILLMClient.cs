using System.Threading;
using System.Threading.Tasks;
using LlmContextualNpc.Models;

namespace LlmContextualNpc.Llm
{
    /// <summary>
    /// Async HTTP to the proxy server. Implementations must honor timeout, a bounded retry count, and cancellation.
    /// The API key stays on the proxy, not in the player.
    /// </summary>
    public interface ILLMClient
    {
        Task<string> SendAsync(LlmPrompt prompt, LlmTransportPolicy policy, CancellationToken cancellationToken);
    }
}
