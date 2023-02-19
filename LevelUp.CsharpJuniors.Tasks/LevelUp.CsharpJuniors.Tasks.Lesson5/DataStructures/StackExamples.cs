namespace LevelUp.CsharpJuniors.Tasks.Lesson5.DataStructures
{
    public sealed class StackExamples
    {
        public void DealWithStacks()
        {
            var stack = new Stack<string>();

            // Put the element on the top of the stack
            stack.Push("Kolobok");
            stack.Push("It");
            stack.Push("Master and Margarita");
            stack.Push("Vinny The Pooh");

            // Check if stack has elements yet
            while (stack.TryPeek(out var book))
            {
                // Get the element from the top of the stack
                _ = stack.Pop();
                Console.WriteLine(book);
            }

            stack.Push("War and Peace");
            stack.Push("Big Soviet Encyclopedia, Vol. 24");

            // Try to get the element from the top of the stack
            while (stack.TryPop(out var book))
            {        
                Console.WriteLine(book);
            }
        }
    }
}
