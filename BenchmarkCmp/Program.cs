using BenchmarkCmp.Comparers;
using BenchmarkCmp.DataLoaders;
using System;
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
                var versionString = Assembly
                    .GetEntryAssembly()
                    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                    .InformationalVersion
                    .ToString();

                Console.WriteLine($"benchmarkcmp v{versionString}");
                Console.WriteLine("Usage:");
                Console.WriteLine("    benchmarkcmp <file1> <file2>");

                return;
            }

            var data1 = DataLoaderFactory.GetLoader(args[0]).LoadBenchmarks(args[0]);
            var data2 = DataLoaderFactory.GetLoader(args[1]).LoadBenchmarks(args[1]);

            var meanComparedData = new MeanComparer().Compare(data1, data2);
            ConsoleTable.From(meanComparedData).Write(new TableFormatting());

            var allocatedBytesComparedData = new AllocatedComparer().Compare(data1, data2);

            if (allocatedBytesComparedData.Length > 0)
            {
                Console.WriteLine();
                ConsoleTable.From(allocatedBytesComparedData).Write(new TableFormatting());
            }
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
