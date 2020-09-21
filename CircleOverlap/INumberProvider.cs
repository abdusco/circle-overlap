using System.Collections.Generic;

namespace CircleOverlap
{
    public interface INumberProvider
    {
        IEnumerable<double> GetNumbers();
    }
}