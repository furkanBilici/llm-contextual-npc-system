using System.Threading;
using System.Threading.Tasks;
using LlmContextualNpc.Models;

namespace LlmContextualNpc.Core
{
    /// <summary>
    /// Applies a validated action or plays a local fallback line. Invalid input must not mutate quest or inventory state.
    /// </summary>
    public interface IGameExecutor
    {
        Task ApplyAsync(LlmActionResponse response, int responseStateVersion, CancellationToken cancellationToken);

        void PlayFallbackDialogue(string npcId, FallbackReason reason);
    }
}
