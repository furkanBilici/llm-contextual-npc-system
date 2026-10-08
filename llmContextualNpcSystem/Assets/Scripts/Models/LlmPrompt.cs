using System;

namespace LlmContextualNpc.Models
{
    /// <summary>
    /// Prompt produced by the NPC brain. StateVersion lets the executor drop a stale reply.
    /// </summary>
    [Serializable]
    public sealed class LlmPrompt
    {
        public string NpcId { get; set; }

        public string SystemText { get; set; }

        public string UserText { get; set; }

        public int StateVersion { get; set; }
    }
}
