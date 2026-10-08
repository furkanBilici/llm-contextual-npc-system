using System.Threading;
using System.Threading.Tasks;
using LlmContextualNpc.Models;

namespace LlmContextualNpc.Npc
{
    /// <summary>
    /// Perception, memory, decision, and prompt assembly for one NPC.
    /// </summary>
    public interface INPCBrain
    {
        string NpcId { get; }

        void Perceive(in GameEvent gameEvent);

        NpcDecision Decide();

        Task<LlmPrompt> BuildPromptAsync(NpcDecision decision, CancellationToken cancellationToken);
    }
}
