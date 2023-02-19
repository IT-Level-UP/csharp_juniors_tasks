namespace LevelUp.CsharpJuniors.Tasks.Lesson5.DataStructures
{
    public sealed class HashTableExamples
    {
        public void DealWithHashTables()
        {
            // Hash table implementation if .NET is Dictionary<TKey, TValue>
            var regions = new Dictionary<int, string>
            {
                { 63, "Samara" },
                { 64, "Saratov" },
                { 69, "Tver" },
                { 78, "Saint-Petersburg" },
            };

            // Add key-value pair
            regions.Add(99, "Moscow");

            // Add key-value pair via index
            regions[58] = "Penza";

            // Check the key is exist and get value by this key
            if (regions.ContainsKey(78))
            {
                Console.WriteLine(regions[78]);
            }

            // Try to get value by key
            if (regions.TryGetValue(63, out var region))
            {
                Console.WriteLine(region);
            }

            // Remove key-value pair
            regions.Remove(99);

            // Get all keys
            var keys = regions.Keys;

            // Get all values
            var values = regions.Values;
        }
    }
}
