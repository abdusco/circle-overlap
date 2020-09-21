using System;

namespace CircleOverlap
{
    public class Circle
    {
        public Vector2 Center { get; }
        public double Radius { get; }

        public Circle(Vector2 center, double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be positive", nameof(radius));
            }

            Center = center;
            Radius = radius;
        }

        public bool Overlaps(Circle other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            return Center.DistanceTo(other.Center) < Radius + other.Radius;
        }

        public double Area => Math.PI * Math.Pow(Radius, 2.0);

        public double OuterDistance(Circle other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            if (Overlaps(other))
            {
                return 0;
            }

            return InnerDistance(other) - Radius - other.Radius;
        }

        public double InnerDistance(Circle other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            return Center.DistanceTo(other.Center);
        }

        public double OverlapArea(Circle other)
        {
            if (!Overlaps(other))
            {
                return 0;
            }

            if (Contains(other))
            {
                return Math.Min(Area, other.Area);
            }

            // https://stackoverflow.com/questions/4247889/area-of-intersection-between-two-circles
            var d = Center.DistanceTo(other.Center);
            var r1 = Radius;
            var r2 = other.Radius;

            var part1 = r1 * r1
                           * Math.Acos(
                               (d * d + r1 * r1 - r2 * r2)
                               / (2.0 * d * r1)
                           );
            var part2 = r2 * r2
                           * Math.Acos(
                               (d * d + r2 * r2 - r1 * r1)
                               / (2.0 * d * r2)
                           );
            var part3 = 0.5 * Math.Sqrt(
                (-d + r1 + r2)
                * (d + r1 - r2)
                * (d - r1 + r2)
                * (d + r1 + r2)
            );

            return part1 + part2 + part3;
        }

        public bool Contains(Circle other)
        {
            return Radius > other.Radius
                   && InnerDistance(other) <= Math.Max(Radius, other.Radius);
        }

        public override string ToString()
        {
            return $"{nameof(Circle)}(r={Radius}, {Center})";
        }
    }
}