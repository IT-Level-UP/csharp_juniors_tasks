namespace SolidPrinciples.OCP
{
    public static class ShapeExtensions
    {
        public static void Draw(this Shape shape)
        {
            var result = shape switch
            {
                Circle => "Drawing circle",
                Square => "Drawing square",
                _ => throw new ArgumentException($"I have no idea how to draw the figure {shape.GetType().Name}")
            };
            
            Console.WriteLine(result);
        }
    }
}
