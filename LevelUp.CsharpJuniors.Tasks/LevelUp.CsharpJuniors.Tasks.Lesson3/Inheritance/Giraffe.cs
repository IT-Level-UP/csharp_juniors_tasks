namespace LevelUp.CsharpJuniors.Tasks.Lesson3.Inheritance;

public sealed class Giraffe : Animal
{
    public override string Name => "Giraffe";
    public override int LegsNumber => 4;

    public override void MakeSound()
    {
        Console.WriteLine("I have no idea what's the trivial giraffe's sound");
    }
}