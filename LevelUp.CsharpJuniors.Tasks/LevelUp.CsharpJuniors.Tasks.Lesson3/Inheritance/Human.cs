namespace LevelUp.CsharpJuniors.Tasks.Lesson3.Inheritance;

public sealed class Human : Animal
{
    public override string Name => "Human";
    public override int LegsNumber => 2;

    public new bool CanFly => true;
    
    public override void MakeSound()
    {
        Console.WriteLine("Where's my coffee, man? I'm going crazy");
    }
}