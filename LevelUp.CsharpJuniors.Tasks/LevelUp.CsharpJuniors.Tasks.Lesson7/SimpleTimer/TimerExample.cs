namespace LevelUp.CsharpJuniors.Tasks.Lesson7.SimpleTimer;

internal class TimerExample
{
    internal static async Task Start(string[] args)
    {
        var period = int.Parse(args[0]);
        var secondsCounter = period;
        while (secondsCounter >= 0)
        {
            Console.WriteLine($"Tick! {secondsCounter--}");
            await Task.Delay(1000);
        }
        
        Console.WriteLine("Time is up!");
    }
}