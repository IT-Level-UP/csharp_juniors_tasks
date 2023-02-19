namespace LevelUp.CsharpJuniors.Tasks.Lesson4.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public sealed class WarmupAttribute : Attribute
{
    internal WarmupLevel Level { get; }
        
    public WarmupAttribute(WarmupLevel level = WarmupLevel.Init)
    {
        Level = level;
    }
}

public enum WarmupLevel
{
    Init = 0,
    Sync = 1,
    Ready = 2,
}