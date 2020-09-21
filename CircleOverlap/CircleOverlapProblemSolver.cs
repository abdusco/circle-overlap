using System;

namespace CircleOverlap
{
    internal class CircleOverlapProblemSolver
    {
        public Report Solve(Problem problem)
        {
            if (problem == null)
            {
                throw new ArgumentNullException(nameof(problem));
            }

            var c1 = problem.Circle1;
            var c2 = problem.Circle2;

            return new Report
            {
                Area  = c1.OverlapArea(c2),
                HasOverlap = c1.IntersectsWith(c2),
                InnerDistance = c1.InnerDistance(c2),
                OuterDistance = c1.OuterDistance(c2),
            };
        }
    }
}