using System;

namespace LlmContextualNpc.Npc
{
    /// <summary>
    /// Personality, current goal, and the action names this NPC may request.
    /// </summary>
    public readonly struct NpcDecision
    {
        public NpcDecision(string npcId, string goalId, string personalityId, string[] allowedActions)
        {
            NpcId = npcId ?? string.Empty;
            GoalId = goalId ?? string.Empty;
            PersonalityId = personalityId ?? string.Empty;
            AllowedActions = allowedActions ?? Array.Empty<string>();
        }

        public string NpcId { get; }

        public string GoalId { get; }

        public string PersonalityId { get; }

        public string[] AllowedActions { get; }
    }
}
