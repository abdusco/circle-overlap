using System;

namespace CircleOverlap
{
    internal class CircleOverlapProblemSolver
    {
        public CircleOverlapReport Solve(CircleOverlapProblem problem)
        {
            if (problem == null)
            {
                throw new ArgumentNullException(nameof(problem));
            }

            var c1 = problem.Circle1;
            var c2 = problem.Circle2;

            return new CircleOverlapReport
            {
                Area  = c1.OverlapArea(c2),
                HasOverlap = c1.Overlaps(c2),
                InnerDistance = c1.InnerDistance(c2),
                OuterDistance = c1.OuterDistance(c2),
            };
        }
    }
}