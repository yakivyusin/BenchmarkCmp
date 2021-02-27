using BenchmarkCmp.Comparers;
using BenchmarkCmp.DataLoaders;
using System;
using System.Collections.Generic;
using System.Reflection;
using YetAnotherConsoleTables;

namespace BenchmarkCmp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                PrintHelp();
                return;
            }

            var data1 = DataLoaderFactory.GetLoader(args[0]).LoadBenchmarks(args[0]);
            var data2 = DataLoaderFactory.GetLoader(args[1]).LoadBenchmarks(args[1]);
            var tableFormat = new TableFormatting();
            var comparers = new List<BaseValueComparer>
            {
                new MeanComparer(),
                new AllocatedComparer(),
                new Gen0Comparer(),
                new Gen1Comparer(),
                new Gen2Comparer(),
                new CompletedWorkItemsComparer()
            };

            foreach (var comparer in comparers)
            {
                var comparedData = comparer.Compare(data1, data2);

                if (comparedData.Length > 0)
                {
                    ConsoleTable.From(comparedData).Write(tableFormat);
                    Console.WriteLine();
                }
            }
        }

        private static void PrintHelp()
        {
            var versionString = Assembly
                    .GetEntryAssembly()
                    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                    .InformationalVersion
                    .ToString();

            Console.WriteLine($"benchmarkcmp v{versionString}");
            Console.WriteLine();
            Console.WriteLine("Usage:");
            Console.WriteLine("    benchmarkcmp <file1> <file2>");
            Console.WriteLine();
            Console.WriteLine("Supported file extensions:");
            Console.WriteLine("    " + string.Join(", ", DataLoaderFactory.SupportedExtensions));
        }

        private class TableFormatting : ConsoleTableFormat
        {
            public TableFormatting() : base(
                columnDelimiter: '|',
                intersection: '+',
                borders: Borders.HeaderDelimiter)
            {

            }
        }
    }
}
