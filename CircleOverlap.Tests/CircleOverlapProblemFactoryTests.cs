using System;
using Xunit;

namespace CircleOverlap.Tests
{
    public class CircleOverlapProblemFactoryTests
    {
        [Fact]
        public void LessThan6NumbersThrowsError()
        {
            var p = new ConstantNumberProvider();
            var factory = new ProblemFactory(p);
            Assert.Throws<ArgumentException>(() =>
            {
                var problem = factory.Create();
            });
        }
    }
}