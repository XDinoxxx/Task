using Xunit;
using AreaShape;

namespace CalcTest
{
    public class CircleTest
    {
        [Fact]
        public void CircleAreaTest1()
        {
            Circle circle = new Circle(5);
            double expect = Math.PI * 5 * 5;
            Assert.Equal(expect, circle.Area());
        }
        [Fact]
        public void CircleAreaTest2()
        {
            Circle circle = new Circle(1.2);
            double expect = Math.PI * 1.2 * 1.2;
            Assert.Equal(expect, circle.Area());
        }
        [Fact]
        public void CircleAreaTest3()
        {
            Circle circle = new Circle(0.001);
            double expect = Math.PI * 0.001 * 0.001;
            Assert.Equal(expect, circle.Area());
        }
    }
    public class TriangleTest
    {
        [Fact]
        public void TriangleAreaTest1()
        {
            Triangle triangle = new Triangle(2,3,4);
            double expect = 2.9;
            Assert.Equal(expect, triangle.Area());
        }
        [Fact]
        public void TriangleAreaTest2()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expect = 6;
            Assert.Equal(expect,triangle.Area());
        }
        [Fact]
        public void TriangleIsRightTest1()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool expect = true;
            Assert.Equal(expect, triangle.IsRightTriangle());
        }
        [Fact]
        public void TriangleIsRightTest2()
        {
            Triangle triangle = new Triangle(2, 3, 4);
            bool expect = false;
            Assert.Equal(expect, triangle.IsRightTriangle());
        }
    }
}