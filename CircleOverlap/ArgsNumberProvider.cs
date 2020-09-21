using System.Collections.Generic;

namespace CircleOverlap
{
    public class ArgsNumberProvider : INumberProvider
    {
        private readonly string[] _args;

        public ArgsNumberProvider(string[] args)
        {
            _args = args;
        }

        public IEnumerable<double> GetNumbers()
        {
            foreach (var token in _args)
            {
                if (double.TryParse(token, out var num))
                {
                    yield return num;
                }
            }
        }
    }
}