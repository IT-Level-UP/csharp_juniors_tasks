using System.Diagnostics;

namespace LevelUp.CsharpJuniors.Tasks.Lesson7.ProcessesAndThreads;

public static class ThreadGenerator
{
    public static void DealWithThreads()
    {
        var threads = Process.GetCurrentProcess().Threads;
        Console.WriteLine("Current process threads info:");
        foreach (ProcessThread thread in threads)
        {
            Console.WriteLine($"\n\tID: {thread.Id}, Priority: {thread.PriorityLevel}");
        }

        for (var i = 0; i < 10; i++)
        {
            void Start()
            {
                Console.WriteLine($"Hello from thread {Environment.CurrentManagedThreadId}");
            }

            var thread = new Thread(Start);
            thread.Start();
        }

        Console.ReadKey();
    }

    public static void DealWithThreadPool()
    {
        for (var i = 0; i < 10; i++)
        {
            ThreadPool.QueueUserWorkItem(ThreadProc, i);
        }
    }

    private static void ThreadProc(object? state)
    {
        Console.WriteLine($"Pool thread with ID {Environment.CurrentManagedThreadId} is processing data {state}");
    }
}