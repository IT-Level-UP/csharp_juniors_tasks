using System.Diagnostics;

namespace LevelUp.CsharpJuniors.Tasks.Lesson7.ProcessesAndThreads;

public static class ProcessGenerator
{
    public static void DealWithProcesses(string[] args)
    {
        var fileName = args[0];
        var timerArgs = args[1];

        Console.WriteLine(fileName);
        Console.WriteLine(timerArgs);

        var processStartInfo = new ProcessStartInfo
        {
            FileName = fileName,
            Arguments = timerArgs
        };

        var process = Process.Start(processStartInfo);
        Console.WriteLine($"\nProcess ID: {process?.Id}" +
            $" \nProcess Name: {process?.ProcessName}" +
            $" \nMachine Name: {process?.MachineName}");
        Console.ReadKey();
    }
}