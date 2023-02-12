namespace LevelUp.CsharpJuniors.Tasks.Lesson3.Inheritance;

public abstract class Animal
{
    public abstract string Name { get; }
    
    public abstract int LegsNumber { get; }

    public bool CanBreathe => true;

    public bool CanFly => false;

    public abstract void MakeSound();
}