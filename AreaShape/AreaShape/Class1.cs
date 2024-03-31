namespace AreaShape
{
    public interface IShape
    {
        double Area();
    }
    public class AreaCalculator() 
    {
        public double CalcArea(IShape shape) 
        {
            return shape.Area();
        }
    }

    public class Circle : IShape 
    {
        private double radius;
        
        public Circle(double r)
        {
            radius = r;
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Triangle : IShape
    {
        private double sideA, sideB, sideC;
        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }
        public double Area()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Round( Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)), 1);
        }

        public bool IsRightTriangle()
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);

            double a = sides[0];
            double b = sides[1];
            double c = sides[2];

            return c * c - (a * a + b * b) < 0.0001;
        }
    }
}
