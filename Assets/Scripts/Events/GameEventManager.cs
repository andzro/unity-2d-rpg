using System.Collections.Generic;

public class GameEventManager
{
    private static GameEventManager instance;
    private List<IEvent> events = new List<IEvent>();

    public static GameEventManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameEventManager();
            }
            return instance;
        }
    }

    private GameEventManager() { }

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
            gameEvent.ExecuteEvent();
        }
    }
}
