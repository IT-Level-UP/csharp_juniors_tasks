namespace LevelUp.CsharpJuniors.Tasks.Lesson7.DelegatesAndEvents;

public static class Delegates
{
    private delegate void PrintDelegate(string text);
    
    public static void DealWithDelegates()
    {
        var printDelegate = new PrintDelegate(Print);
        printDelegate("Print through delegate");

        var action = new Action<string>(Print);
        action("Print through action");

        var func = new Func<string>(PrepareText);
        Console.WriteLine(func());
    }

    public static void DealWithMulticastDelegates()
    {
        var actionOne = new Action(HelloOne);
        var actionTwo = new Action(HelloTwo);

        var chain = actionOne + actionTwo;
        
        Console.WriteLine("Call two delegates in chain:");
        chain();

        Console.WriteLine("Remove one delegate from chain:");
        chain -= actionTwo;
        chain();
    }

    private static string PrepareText()
    {
        return "Print through func";
    }
    
    private static void Print(string text)
    {
        Console.WriteLine(text);
    }

    private static void HelloOne()
    {
        Console.WriteLine("\tHello from HelloOne!");
    }
    
    private static void HelloTwo()
    {
        Console.WriteLine("\tHello from HelloTwo!");
    }
}