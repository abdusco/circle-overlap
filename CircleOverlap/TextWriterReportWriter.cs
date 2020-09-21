using System.IO;

namespace CircleOverlap
{
    internal class ConsoleSolutionWriter : IReportWriter
    {
        private readonly TextWriter _output;

        public ConsoleSolutionWriter(TextWriter output)
        {
            _output = output;
        }

        public void Write(CircleOverlapReport report)
        {
            _output.WriteLine($"{nameof(CircleOverlapReport.HasOverlap)}: {report.HasOverlap}");
            _output.WriteLine($"{nameof(CircleOverlapReport.Area)}: {report.Area}");
            _output.WriteLine($"{nameof(CircleOverlapReport.InnerDistance)}: {report.InnerDistance}");
            _output.WriteLine($"{nameof(CircleOverlapReport.OuterDistance)}: {report.OuterDistance}");
        }
    }
}