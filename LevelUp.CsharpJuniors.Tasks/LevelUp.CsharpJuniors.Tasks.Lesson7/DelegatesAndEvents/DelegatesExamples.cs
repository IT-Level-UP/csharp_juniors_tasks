namespace LevelUp.CsharpJuniors.Tasks.Lesson7.DelegatesAndEvents;

public sealed class DelegatesExamples
{
    public void DealWithDelegates()
    {
        Delegates.DealWithDelegates();
        Delegates.DealWithMulticastDelegates();
    }

    public void DealWithEvents()
    {
        var generator = new EventGenerator();
        _ = new EventListener(generator, 1);
        _ = new EventListener(generator, 2);
        _ = new EventListener(generator, 3);

        generator.RaiseEvent();
    }
}