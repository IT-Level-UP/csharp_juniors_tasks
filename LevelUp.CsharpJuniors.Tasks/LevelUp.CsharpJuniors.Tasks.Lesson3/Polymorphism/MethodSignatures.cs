using System.Globalization;

namespace LevelUp.CsharpJuniors.Tasks.Lesson3.Polymorphism;

public sealed class MethodSignatures
{
    public void PlayWithMethods()
    {
        // booleans
        Console.WriteLine(true);
        
        // chars
        Console.WriteLine('a');

        // char array
        var charArray = new[] { 'I', ' ', 's', 'e', 'e', ' ', 's', 'h', 'a', 'r', 'p' };
        Console.WriteLine(charArray);
        
        //char array with shifting
        Console.WriteLine(charArray, 6, 5);

        // decimals
        Console.WriteLine(123.45M);
        
        // doubles
        Console.WriteLine(123.45D);
        
        // floats
        Console.WriteLine(123.45F);
        
        // ints
        Console.WriteLine(123);
        
        // longs
        Console.WriteLine(123L);
        
        // DateTime
        Console.WriteLine(DateTime.Now);
        
        // objects and other ref types
        Console.WriteLine(new object());
        
        // strings, incl. interpolation
        Console.WriteLine($"Time is {DateTime.Now.ToLocalTime()} now");
        
        // formatted strings with one argument
        Console.WriteLine("Time is {0} now", DateTime.Now.ToString("t", CultureInfo.CurrentCulture));
        
        // Formatted strings with multiple arguments
        Console.WriteLine("Today is {0}, Time is {1} now",
            DateTime.Now.Date.ToString("d", CultureInfo.CurrentCulture),
            DateTime.Now.ToString("t", CultureInfo.CurrentCulture));
    }
}