using LevelUp.CsharpJuniors.Tasks.Lesson3.Inheritance;

namespace LevelUp.CsharpJuniors.Tasks.Lesson3.Polymorphism;

public sealed class PolymorphicBehavior
{
    public void PlayWithPolymorphism()
    {
        var cat = new Cat();
        var siberian = new SiberianCat();
        var maineCoon = new MaineCoon();
        
        ListenAnimal(cat);
        ListenAnimal(siberian);
        ListenAnimal(maineCoon);

        ListenCat(cat);
        ListenCat(siberian);
        ListenCat(maineCoon);

        ListenBreed(siberian);
        ListenBreed(maineCoon);
        
        ListenBreed(siberian);
        ListenBreed(maineCoon);

        var tiger = new Tiger();
        ListenCat(tiger);
        ListenTiger(tiger);
    }

    private void ListenAnimal(Animal animal)
    {
        animal.MakeSound();
    }
    
    private void ListenCat(Cat cat)
    {
        cat.MakeSound();
    }
    
    private void ListenBreed(SiberianCat siberianCat)
    {
        siberianCat.MakeSound();
    }
    
    private void ListenBreed(MaineCoon maineCoon)
    {
        maineCoon.MakeSound();
    }
    
    private void ListenTiger(Tiger tiger)
    {
        tiger.MakeSound();
        ((Cat)tiger).MakeSound();
    }
}