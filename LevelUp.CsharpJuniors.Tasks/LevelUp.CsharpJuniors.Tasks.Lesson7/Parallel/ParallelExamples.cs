namespace LevelUp.CsharpJuniors.Tasks.Lesson7.Parallel;

public static class ParallelExamples
{
    public static void DealWithParallelFor()
    {
        System.Threading.Tasks.Parallel.For(0, 10, LongRunningOperation);
    }
    
    public static void DealWithParallelForEach()
    {
        var range = Enumerable.Range(0, 10);

        System.Threading.Tasks.Parallel.ForEach(range, LongRunningOperation);
    }
    
    public static async Task DealWithParallelForEachAsync()
    {
        var range = Enumerable.Range(0, 10);
        await System.Threading.Tasks.Parallel.ForEachAsync(range, LongRunningOperationAsync);
    }

    public static void DealWithLinqAsParallel()
    {
        var range = Enumerable.Range(0, 10);
        var sinuses = range.AsParallel().SelectMany(i =>
        {
            var rangeFrom = i * 100;
            var rangeTo = rangeFrom + 99;

            var sinuses = new (int, double)[100];
            for (var currNumber = rangeFrom; currNumber <= rangeTo; currNumber++)
            {
                var idx = currNumber - i * 100;
                sinuses[idx] = (currNumber, Math.Sin(currNumber));
            }

            return sinuses;
        });
        
        var result = sinuses.OrderBy(item => item.Item1).ToArray();
        Console.WriteLine(result.Length);
    }
    
    private static void LongRunningOperation(int operationId)
    {
        var rangeFrom = operationId * 100;
        var rangeTo = rangeFrom + 99;
        
        Console.WriteLine($"Calculating sinuses for range {rangeFrom} to {rangeTo}");

        for (var currNumber = rangeFrom; currNumber <= rangeTo; currNumber++)
        {
            Console.WriteLine($"Sinus of {currNumber} is {Math.Sin(currNumber)}");    
        }

        Console.WriteLine($"The operation for range {rangeFrom} to {rangeTo} has successfully processed");
    }

    private static ValueTask LongRunningOperationAsync(int operationId, CancellationToken token)
    {
        LongRunningOperation(operationId);
        return ValueTask.CompletedTask;
    }
}