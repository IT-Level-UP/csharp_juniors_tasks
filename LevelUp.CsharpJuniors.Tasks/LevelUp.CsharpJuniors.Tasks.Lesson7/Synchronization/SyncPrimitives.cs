namespace LevelUp.CsharpJuniors.Tasks.Lesson7.Synchronization;

public static class SyncPrimitives
{
    public static void DealWithNoSynchronization()
    {
        var counter = 0;

        Console.WriteLine("Naive incrementing");
        System.Threading.Tasks.Parallel.For(0, 50_000, _ => counter++);
        Console.WriteLine(counter);
    }
    
    public static void DealWithInterlocked()
    {
        var counter = 0;
        
        Console.WriteLine("Synced incrementing");
        System.Threading.Tasks.Parallel.For(0, 50_000, _ => Interlocked.Increment(ref counter));
        Console.WriteLine(counter);
    }

    public static void DealWithMonitor()
    {
        object syncObj = new object();
        var counter = 0;
        
        Console.WriteLine("Incrementing with monitor");
        System.Threading.Tasks.Parallel.For(0, 50_000, _ => Increment());
        Console.WriteLine(counter);
        
        void Increment()
        {
            try
            {
                Monitor.Enter(syncObj);
                counter++;
            }
            finally
            {
                Monitor.Exit(syncObj);
            }
        }
    }
    
    public static void DealWithLock()
    {
        object syncObj = new object();
        var counter = 0;
        
        Console.WriteLine("Incrementing with lock");
        System.Threading.Tasks.Parallel.For(0, 50_000, _ => Increment());
        Console.WriteLine(counter);
        
        void Increment()
        {
            lock (syncObj)
            {
                counter++;
            }
        }
    }

    public static void DealWithMutex()
    {
        var mtx = new Mutex(false);
        
        var counter = 0;
        
        Console.WriteLine("Incrementing with mutex");
        System.Threading.Tasks.Parallel.For(0, 50_000, _ => Increment());
        Console.WriteLine(counter);

        void Increment()
        {
            mtx.WaitOne();
            counter++;
            mtx.ReleaseMutex();
        }
    }
    
    public static void DealWithSemaphore()
    {
        var semaphore = new Semaphore(1, 1);
        
        var counter = 0;
        
        Console.WriteLine("Incrementing with semaphore");
        System.Threading.Tasks.Parallel.For(0, 50_000, _ => Increment());
        Console.WriteLine(counter);

        void Increment()
        {
            semaphore.WaitOne();
            counter++;
            semaphore.Release();
        }
    }
    
    public static void DealWithSemaphoreSlim()
    {
        var semaphore = new SemaphoreSlim(1, 1);
        
        var counter = 0;
        
        Console.WriteLine("Incrementing with semaphore slim");
        System.Threading.Tasks.Parallel.For(0, 50_000, _ => Increment());
        Console.WriteLine(counter);

        void Increment()
        {
            semaphore.Wait();
            counter++;
            semaphore.Release();
        }
    }
}