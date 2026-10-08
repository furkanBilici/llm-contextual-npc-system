using System;
using System.Collections.Generic;

namespace LlmContextualNpc.Models
{
    /// <summary>
    /// Read-only view of world facts the validator may check. Callers should pass pooled or reused lists.
    /// </summary>
    public sealed class GameStateSnapshot
    {
        public IReadOnlyCollection<string> InventoryItemIds { get; set; } = Array.Empty<string>();

        public IReadOnlyCollection<string> KnownQuestIds { get; set; } = Array.Empty<string>();

        public IReadOnlyCollection<string> KnownTargetIds { get; set; } = Array.Empty<string>();

        public IReadOnlyCollection<string> AllowedActions { get; set; } = Array.Empty<string>();

        public int StateVersion { get; set; }
    }
}
