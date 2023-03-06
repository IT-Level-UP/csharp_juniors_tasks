namespace SolidPrinciples.OCP
{
    public sealed class Circle : Shape
    {
        private readonly float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
