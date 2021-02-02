using BenchmarkCmp.Models.Input.Json;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace BenchmarkCmp.DataLoaders.Concrete
{
    public class JsonDataLoader : IDataLoader
    {
        public Models.Internal.Benchmark[] LoadBenchmarks(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var input = JsonSerializer.Deserialize<JsonRootObject>(json);

            return input
                .Benchmarks
                .Select(x => new Models.Internal.Benchmark
                {
                    Name = x.DisplayInfo,
                    Mean = x.Statistics.Mean,
                    AllocatedBytes = x.Memory?.BytesAllocatedPerOperation,
                    Gen0Collects = x.Memory?.Gen0Collections,
                    Gen1Collects = x.Memory?.Gen1Collections,
                    Gen2Collects = x.Memory?.Gen2Collections
                })
                .ToArray();
        }
    }
}
