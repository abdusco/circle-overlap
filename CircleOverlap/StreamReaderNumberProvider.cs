using System.IO;

namespace CircleOverlap
{
    class StreamReaderNumberProvider : TextReaderNumberProvider
    {
        public StreamReaderNumberProvider(Stream stream) : base(new StreamReader(stream))
        {
        }
    }
}