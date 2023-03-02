namespace LevelUp.CsharpJuniors.Tasks.Lesson7.Tasks;

public static class TaskExamples
{
    public static void DealWithSynchronousTask()
    {
        // Synchronous execution
        var synchronousTask = new Task(DoWork);
        synchronousTask.RunSynchronously();

        var synchronousTaskWithResult = new Task<string>(DoWorkWithResult);
        synchronousTaskWithResult.RunSynchronously();
        
        var taskResult = synchronousTaskWithResult.Result;
        Console.WriteLine("Synchronous task result: " + taskResult);
    }

    public static void DealWithFireAndForgetTask()
    {
        var fafTask = Task.Run(DoWork);

        Console.WriteLine("FAF task status before work: " + fafTask.Status);

        Thread.Sleep(1000);
        
        Console.WriteLine("FAF task status after work: " + fafTask.Status);
    }

    public static void DealWithGroupOfTasks()
    {
        var tasks = new Task[4];
        for (var i = 0; i < 4; i++)
        {
            var timeCoefficient = i + 1;
            tasks[i] = Task.Run(() => DoLongRunningWork(timeCoefficient * 1000));
        }

        Task.WaitAll(tasks);
    }

    public static void DealWithTaskFactory()
    {
        var taskFactory = new TaskFactory();
        var task = taskFactory.StartNew(DoWork);
        
        Console.WriteLine(task.Status);
        
        Thread.Sleep(1000);
        
        Console.WriteLine(task.Status);
    }

    public static void DealWithCancellation()
    {
        var cts = new CancellationTokenSource();
        cts.CancelAfter(100);
        
        var task = Task.Run(() => DoLongRunningWork(10000, cts.Token), cts.Token);
        
        Console.WriteLine(task.Status);
        
        Thread.Sleep(3000);
        
        Console.WriteLine(task.Status);
    }

    public static async Task DealWithAsynchronousTask()
    {
        // Await Task via variable
        var asyncTask = Task.Run(() => DoLongRunningWork(10000));
        await asyncTask;

        // Await Task via method
        await DoWorkAsync();
        
        // Get the result of the async method
        var result = await DoWorkWithResultAsync();
        Console.WriteLine(result);
    }

    public static Task<string> DealWithTaskReturnWithoutAsync()
    {
        return Task.FromResult("Result without async call");
    }

    public static async Task DealWithTaskContinuations()
    {   
        var firstTask = Task.Run(DoWork);
        var secondTask = () => Console.WriteLine("I'd run only if the first task will be finished correctly");
        Action thirdTask = () => throw new Exception();
        var fourthTask = () => Console.WriteLine("I'd run only after the faulted task");

        await firstTask
            .ContinueWith(_ => secondTask(), TaskContinuationOptions.OnlyOnRanToCompletion)
            .ContinueWith(_ => thirdTask())
            .ContinueWith(_ => fourthTask(), TaskContinuationOptions.OnlyOnFaulted);
    }
    
    private static void DoWork()
    {
        Console.WriteLine("Performing some work");
    }
    
    private static string DoWorkWithResult()
    {
        Console.WriteLine("Performing some work with the result");
        return "Done.";
    }

    private static async Task DoWorkAsync()
    {
        Console.WriteLine("Performing some work asynchronously");
        await Task.Delay(1000);
    }
    
    private static async Task<string> DoWorkWithResultAsync()
    {
        Console.WriteLine("Performing some work asynchronously with the result");
        await Task.Delay(1000);
        return "Done.";
    }
    
    private static void DoLongRunningWork(int time, CancellationToken token = default)
    {
        Console.WriteLine($"Performing some long-running work: {time}");
        var timeLeft = time;

        while (timeLeft > 0)
        {
            token.ThrowIfCancellationRequested();
            Thread.Sleep(1000);
            timeLeft -= 1000;
        }
        
        Console.WriteLine("Finished long-running task");
    }
}