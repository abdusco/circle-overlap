using System;
using System.Numerics;
using Xunit;

namespace CircleOverlap.Tests
{
    public class CircleTests
    {
        [Fact]
        public void NegativeRadiusThrowsError()
        {
            Assert.Throws<ArgumentException>(() => { new Circle(new Vector2(0, 0), -1); });
        }

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(0, 0)]
        public void AreaCalculationWorks(double radius, double expected)
        {
            var c = new Circle(new Vector2(0, 0), radius);
            Assert.Equal(expected, c.Area);
        }

        [Fact]
        public void IntersectingCirclesHaveOverlapAreaEqualToSmallerCircle()
        {
            var small = new Circle(new Vector2(0, 0), 1);
            var large = new Circle(new Vector2(0, 0), 2);

            Assert.True(large.IntersectsWith(small));
            Assert.Equal(small.Area, large.OverlapArea(small));
        }

        [Theory]
        [InlineData(0, 0, 1, 0, 1, 1, 2.960420506177634)]
        [InlineData(0, 0, 2, 0, 1, 1, Math.PI)]
        public void OverlapCalculationWorks(double x1, double y1, double r1, double x2, double y2, double r2,
            double overlapArea)
        {
            var c1 = new Circle(new Vector2(x1, y1), r1);
            var c2 = new Circle(new Vector2(x2, y2), r2);
            var area = c1.OverlapArea(c2);

            Assert.Equal(overlapArea, area);
        }
    }
}