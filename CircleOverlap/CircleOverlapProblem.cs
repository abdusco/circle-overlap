using System;

namespace CircleOverlap
{
    public class CircleOverlapProblem
    {
        public Circle Circle1 { get; }
        public Circle Circle2 { get; }

        public CircleOverlapProblem(Circle c1, Circle c2)
        {
            Circle1 = c1 ?? throw new ArgumentNullException(nameof(c1));
            Circle2 = c2 ?? throw new ArgumentNullException(nameof(c2));
        }
    }
}