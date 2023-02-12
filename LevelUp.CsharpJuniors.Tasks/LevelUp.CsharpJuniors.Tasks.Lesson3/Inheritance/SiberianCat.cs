namespace LevelUp.CsharpJuniors.Tasks.Lesson3.Inheritance;

public sealed class SiberianCat : Cat
{
    public override string Breed => "Siberian Beauty";

    public override void MakeSound()
    {
        Console.WriteLine("murrrrr!");
    }
}