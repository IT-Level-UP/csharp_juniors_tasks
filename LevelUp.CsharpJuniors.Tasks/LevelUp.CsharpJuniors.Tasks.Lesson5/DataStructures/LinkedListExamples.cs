namespace LevelUp.CsharpJuniors.Tasks.Lesson5.DataStructures
{
    public sealed class LinkedListExamples
    {
        public void DealWithLinkedLists()
        {
            var linkedList = new LinkedList<int>();

            // Add first element
            var first = linkedList.AddFirst(6);

            // Add element after other
            var second = linkedList.AddAfter(first, 42);

            // Get the info about previous element before the second
            Console.WriteLine(second.Previous);

            // Get the info about next element after the second
            Console.WriteLine(second.Next);

            // Add last element
            var last = linkedList.AddLast(9);

            // Add element before other
            var third = linkedList.AddBefore(last, 14);

            foreach (var element in linkedList)
            {
                Console.WriteLine(element); // 6 42 14 9
            }
        }
    }
}
