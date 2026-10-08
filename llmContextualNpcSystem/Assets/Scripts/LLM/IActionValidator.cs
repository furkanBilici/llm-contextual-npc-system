using LlmContextualNpc.Models;

namespace LlmContextualNpc.Llm
{
    /// <summary>
    /// Checks JSON shape, allowed actions, known quest and target ids, and preconditions such as inventory.
    /// A failed result must leave the game state unchanged.
    /// </summary>
    public interface IActionValidator
    {
        ActionValidationResult Validate(string rawJson, GameStateSnapshot state);
    }
}
