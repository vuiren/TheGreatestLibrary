using TestTaskMindbox;
using Xunit;

namespace Tests
{
    public class FiguresTests
    {
        double delta = 0.01;

        [Fact]
        public void CircleAreaIsCorrect()
        {
            var circle = new Circle(5);
            var answer = 25 * Math.PI;
            Assert.InRange(circle.Area(), answer - delta, answer + delta);
        }

        [Fact]
        public void CircleRadiusCantBeNegative()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-20));
        }

        [Fact]
        public void CircleRadiusCantBeZero()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Fact]
        public void TriangleAreaIsCorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            var answer = 6.0;
            Assert.InRange(triangle.Area(), answer - delta, answer + delta);
        }

        [Fact]
        public void TriangleIsRight()
        {
            var triangle = new Triangle(5, 12, 13);
            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void TriangleIsNotRight()
        {
            var triangle = new Triangle(5, 7, 10);
            Assert.False(triangle.IsRight());
        }

        [Fact]
        public void TriangleSidesCantBeNegative()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-20, 20, 230));
        }

        [Fact]
        public void TriangleSidesCantBeZero()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 1, 2));
        }

        [Fact]
        public void TrianglesTwoSidesMustAlwaysBeBiggerThanAThirdSide()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(7, 2, 3));
        }
    }
}