using System;
using System.IO;
using System.Linq;

namespace CircleOverlap
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Contains("--help"))
            {
                PrintHelp();
                return;
            }
            
            try
            {
                // use program arguments
                if (!args.Any())
                {
                    PrintHelp();
                    return;
                }
                INumberProvider numberProvider = new ArgsNumberProvider(args);
                
                // or other implementations
                // INumberProvider numberProvider = new TextReaderNumberProvider(Console.In);
                // INumberProvider numberProvider = new ConstantNumberProvider(0, 0, 1, 1, 0, 1);
                // INumberProvider numberProvider = new StreamReaderNumberProvider(File.OpenRead("./numbers.txt"));
                
                var problemFactory = new ProblemFactory(numberProvider);
                var problem = problemFactory.Create();

                var solver = new ProblemSolver();
                var solution = solver.Solve(problem);

                IReportWriter reportWriter = new ConsoleReportWriter(Console.Out);
                reportWriter.Write(solution);
            }
            catch (Exception e)
            {
                LogError(e);
                PrintHelp();
            }
        }

        private static void PrintHelp()
        {
            Console.WriteLine(
                "Type in the coordinates and the radius for two circles as: " +
                "<x1> <y1> <r1> <x2> <y2> <r2>"
            );
        }

        private static void LogError(Exception exception)
        {
            Console.Error.WriteLine(exception.Message);
        }
    }
}