using System;

namespace CircleOverlap
{
    public class Vector2
    {
        public double X { get; }
        public double Y { get; }

        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Vector2 other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            return Math.Sqrt(Math.Pow(X - other.X, 2.0) + Math.Pow(Y - other.Y, 2.0));
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}