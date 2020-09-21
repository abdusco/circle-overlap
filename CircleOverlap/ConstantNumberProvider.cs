using System.Collections.Generic;

namespace CircleOverlap
{
    public class ConstantNumberProvider : INumberProvider
    {
        private readonly IEnumerable<double> _numbers;

        public ConstantNumberProvider(params double[] numbers)
        {
            _numbers = numbers;
        }

        public IEnumerable<double> GetNumbers() => _numbers;
    }
}