namespace LevelUp.CsharpJuniors.Tasks.Lesson3.Inheritance;

public sealed class Tiger : Cat
{
    public override string Breed => "Tiger";

    public new void MakeSound()
    {
        Console.WriteLine("Eye of tiiiiger!");
    }
}