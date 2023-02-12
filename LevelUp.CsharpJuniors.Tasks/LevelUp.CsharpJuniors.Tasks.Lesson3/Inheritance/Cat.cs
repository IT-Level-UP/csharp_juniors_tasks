namespace LevelUp.CsharpJuniors.Tasks.Lesson3.Inheritance;

public class Cat : Animal
{
    public override string Name => "Cat";
    public override int LegsNumber => 4;
    public virtual string Breed => "Simple Home Nyashka";

    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}