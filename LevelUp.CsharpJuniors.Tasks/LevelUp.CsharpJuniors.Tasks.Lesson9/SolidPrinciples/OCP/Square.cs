namespace SolidPrinciples.OCP
{
    public class Square : Shape
    {
        private readonly double _sideSize;

        public Square(double sideSize)
        {
            _sideSize = sideSize;
        }
        
        public override double CalculateArea()
        {
            return Math.Pow(_sideSize, 2);
        }
    }
}
