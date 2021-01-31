using BenchmarkCmp.Models.Internal;

namespace BenchmarkCmp.DataLoaders
{
    public interface IDataLoader
    {
        Benchmark[] LoadBenchmarks(string filePath);
    }
}
