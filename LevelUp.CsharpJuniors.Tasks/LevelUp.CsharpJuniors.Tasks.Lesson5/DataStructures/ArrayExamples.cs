namespace LevelUp.CsharpJuniors.Tasks.Lesson5.DataStructures
{
    public sealed class ArrayExamples
    {
        public void DealWithArrays()
        {
            // Simple one-dimensional array of ints
            int[] simpleArray = new int[4] { 0, 1, 2, 3 };
            Console.WriteLine(simpleArray[0]); // 0

            // Two-dimensional array of ints
            int[,] twoDimensionalArray = new int[2, 3]
            {
                { -1, 0, 1 },
                { 2, 3, 4 }
            };
            Console.WriteLine(twoDimensionalArray[0, 0]); // -1

            // Jagged array of ints
            int[][] jaggedArray = new int[4][]
            {
                new [] { -1, 0 },
                new [] { 1, 2, 3 },
                new [] { 4 },
                new [] { 5, 6, 7, 8 }
            };

            Console.WriteLine(jaggedArray[0][0]); // -1
        }
    }
}
