using System;

namespace LlmContextualNpc.Models
{
    public enum GameEventType
    {
        ConversationStarted = 0,
        ZoneEntered = 1,
        ItemDelivered = 2
    }

    public readonly struct GameEvent
    {
        public GameEvent(GameEventType type, string npcId, string subjectId, int stateVersion)
        {
            Type = type;
            NpcId = npcId ?? string.Empty;
            SubjectId = subjectId ?? string.Empty;
            StateVersion = stateVersion;
        }

        public GameEventType Type { get; }

        public string NpcId { get; }

        /// <summary>Zone id, item id, or conversation partner id, depending on <see cref="Type"/>.</summary>
        public string SubjectId { get; }

        public int StateVersion { get; }
    }
}
