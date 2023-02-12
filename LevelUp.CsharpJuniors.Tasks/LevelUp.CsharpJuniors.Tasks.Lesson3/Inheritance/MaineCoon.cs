namespace LevelUp.CsharpJuniors.Tasks.Lesson3.Inheritance;

public sealed class MaineCoon : Cat
{
    public override string Breed => "Maine Coon";

    public override void MakeSound()
    {
        Console.WriteLine("MAAAAAAOWWW!!!");
    }
}