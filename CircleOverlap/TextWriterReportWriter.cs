using System.IO;

namespace CircleOverlap
{
    internal class ConsoleReportWriter : IReportWriter
    {
        private readonly TextWriter _output;

        public ConsoleReportWriter(TextWriter output)
        {
            _output = output;
        }

        public void Write(Report report)
        {
            _output.WriteLine($"{nameof(Report.HasOverlap)}: {report.HasOverlap}");
            _output.WriteLine($"{nameof(Report.Area)}: {report.Area}");
            _output.WriteLine($"{nameof(Report.InnerDistance)}: {report.InnerDistance}");
            _output.WriteLine($"{nameof(Report.OuterDistance)}: {report.OuterDistance}");
        }
    }
}