using System;
using System.Collections.Generic;
using System.IO;

namespace CircleOverlap
{
    class ConsoleNumberProvider : INumberProvider
    {
        private readonly TextReader _input;

        public ConsoleNumberProvider(TextReader input)
        {
            _input = input;
        }

        public IEnumerable<double> GetNumbers()
        {
            var line = _input.ReadLine();
            if (line == null)
            {
                yield break;
            }

            foreach (var token in line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                if (double.TryParse(token, out var num))
                {
                    yield return num;
                }
            }
        }
    }
}