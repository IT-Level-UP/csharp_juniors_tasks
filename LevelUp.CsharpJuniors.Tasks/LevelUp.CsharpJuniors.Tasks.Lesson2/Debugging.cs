using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUp.CsharpJuniors.Tasks.Lesson2;

public sealed class Debugging
{
    public void PlayWithDebugging()
    {
        var someVariable = 12;
        var oneMoreVariable = 6;

        var result = someVariable / oneMoreVariable;

        InternalMethod();

        Console.WriteLine(result);
    }

    private void InternalMethod()
    {
        Console.WriteLine("Internal method has been called");
    }
}