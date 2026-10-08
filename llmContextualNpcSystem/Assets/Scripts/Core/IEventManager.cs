using System;
using LlmContextualNpc.Models;

namespace LlmContextualNpc.Core
{
    /// <summary>
    /// Publishes gameplay events. Implementations must not block the Unity player loop.
    /// </summary>
    public interface IEventManager
    {
        void Subscribe(GameEventType type, Action<GameEvent> handler);

        void Unsubscribe(GameEventType type, Action<GameEvent> handler);

        void Publish(in GameEvent gameEvent);
    }
}
