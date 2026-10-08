using System;
using System.Text.Json.Serialization;

namespace LlmContextualNpc.Models
{
    /// <summary>
    /// Structured LLM action contract. Field names match the project JSON sample.
    /// </summary>
    [Serializable]
    public sealed class LlmActionResponse
    {
        [JsonPropertyName("dialogue")]
        public string Dialogue { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("quest_id")]
        public string QuestId { get; set; }

        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }
    }
}
