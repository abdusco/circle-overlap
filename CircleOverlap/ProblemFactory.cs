using System;
using System.Linq;

namespace CircleOverlap
{
    public class ProblemFactory
    {
        private readonly INumberProvider _numberProvider;

        public ProblemFactory(INumberProvider numberProvider)
        {
            _numberProvider = numberProvider;
        }

        public Problem Create()
        {
            var numbers = _numberProvider.GetNumbers().Take(6).ToList();
            if (numbers.Count != 6)
            {
                throw new ArgumentException("Must provide 6 numbers", nameof(_numberProvider));
            }

            var c1 = new Circle(new Vector2(numbers[0], numbers[1]), numbers[2]);
            var c2 = new Circle(new Vector2(numbers[3], numbers[4]), numbers[5]);
            
            return new Problem(c1, c2);
        }
    }
}