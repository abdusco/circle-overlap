using System;
using System.Linq;

namespace CircleOverlap
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Contains("--help") || !args.Any())
            {
                PrintHelp();
                return;
            }
            
            try
            {
                // use console arguments
                INumberProvider numberProvider = new ArgsNumberProvider(args);
                // but there are other implementations too
                
                // INumberProvider numberProvider = new ConsoleNumberProvider(Console.In);
                // INumberProvider numberProvider = new ConstantNumberProvider(0, 0, 1, 1, 0, 1);
                
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