namespace LevelUp.CsharpJuniors.Tasks.Lesson7.DelegatesAndEvents;

public class EventGenerator
{
    public delegate void MessageReceivedEventHandler(object sender, MessageReceivedEventArgs eventArgs); 
    
    public event MessageReceivedEventHandler? MessageReceivedEvent;
    
    public virtual void RaiseEvent()
    {
        MessageReceivedEvent?.Invoke(this, new MessageReceivedEventArgs("Hello"));
    }
}

public class MessageReceivedEventArgs
{
    public MessageReceivedEventArgs(string message)
    {
        Message = message;
    }
    
    public string Message { get; }
}

public sealed class EventListener
{
    private readonly int _listenerId;
    
    public EventListener(EventGenerator eventGenerator, int listenerId)
    {
        _listenerId = listenerId;
        eventGenerator.MessageReceivedEvent += Listen;
    }
    
    private void Listen(object sender, MessageReceivedEventArgs eventArgs)
    {
         Console.WriteLine($"Listener {_listenerId} received message: {eventArgs.Message}");
    }
}