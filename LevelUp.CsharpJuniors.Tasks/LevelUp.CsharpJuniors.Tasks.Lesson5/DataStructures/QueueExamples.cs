namespace LevelUp.CsharpJuniors.Tasks.Lesson5.DataStructures
{
    public sealed class QueueExamples
    {
        public void DealWithQueues()
        {
            var queue = new Queue<int>();
            
            // Add elements to the tail of the queue
            queue.Enqueue(1);
            queue.Enqueue(14);
            queue.Enqueue(42);
            queue.Enqueue(156);

            // Check if queue has elements yet
            while (queue.TryPeek(out var number))
            {
                _ = queue.Dequeue();
                Console.WriteLine(number);
            }

            queue.Enqueue(57);
            queue.Enqueue(239);

            // Try to get value from the tail of the queue
            while (queue.TryDequeue(out var number))
            {
                Console.WriteLine(number);
            }
        }
    }
}
