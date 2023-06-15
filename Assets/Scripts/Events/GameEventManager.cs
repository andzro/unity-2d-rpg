using System.Collections.Generic;

public class GameEventManager
{
    private List<IEvent> events = new List<IEvent>();

    public void RegisterEvent(IEvent gameEvent)
    {
        events.Add(gameEvent);
    }

    public void UnregisterEvent(IEvent gameEvent)
    {
        events.Remove(gameEvent);
    }

    public void TriggerEvents()
    {
        foreach (IEvent gameEvent in events)
        {
            gameEvent.Execute();
        }
    }
}
