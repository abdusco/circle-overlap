using System;
using System.Linq;

namespace CircleOverlap
{
    public class CircleOverlapProblemFactory
    {
        private readonly INumberProvider _numberProvider;

        public CircleOverlapProblemFactory(INumberProvider numberProvider)
        {
            _numberProvider = numberProvider;
        }

        public CircleOverlapProblem Create()
        {
            var numbers = _numberProvider.GetNumbers().Take(6).ToList();
            if (numbers.Count != 6)
            {
                throw new ArgumentException("Must provide 6 numbers", nameof(_numberProvider));
            }

            var c1 = new Circle(new Vector2(numbers[0], numbers[1]), numbers[2]);
            var c2 = new Circle(new Vector2(numbers[3], numbers[4]), numbers[5]);
            
            return new CircleOverlapProblem(c1, c2);
        }
    }
}