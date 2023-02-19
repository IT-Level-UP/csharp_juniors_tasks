namespace LevelUp.CsharpJuniors.Tasks.Lesson5.DataStructures
{
    public sealed class ListExamples
    {
        public void DealWithLists()
        {
            // Simple list initialization
            var ints = new List<int>();

            // List initialization with the start list capacity
            var strings = new List<string>(10);

            // List initialization with initialization body
            var floats = new List<float>
            {
                1.0f, 2.15f, 42.1f
            };

            // Add element to the end of the list
            ints.Add(7);

            // Add several elements by time
            strings.AddRange(new List<string> { "Str1", "Str2", "Str3" });

            // Insert new element by index
            floats.Insert(0, 12.4f);

            // Get element by index
            var firstItem = ints[0];
            Console.WriteLine(firstItem); // 7

            // Find the index of the element
            var idx = strings.IndexOf("Str3");
            Console.WriteLine(idx); // 2
        }
    }
}
