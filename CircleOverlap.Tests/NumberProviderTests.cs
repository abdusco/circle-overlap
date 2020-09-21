using System.Linq;
using Xunit;

namespace CircleOverlap.Tests
{
    public class NumberProviderTests
    {
        [Fact]
        public void ConstantProviderReturnsNothingWithNoInput()
        {
            var p = new ConstantNumberProvider();
            Assert.Empty(p.GetNumbers());
        }

        [Fact]
        public void ConstantProviderReturnsAllNumbers()
        {
            var p = new ConstantNumberProvider(1, 2, 3);
            Assert.Equal(3, p.GetNumbers().Count());
        }
    }
}