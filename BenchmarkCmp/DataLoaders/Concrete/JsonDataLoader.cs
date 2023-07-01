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
                    Min = x.Statistics.Min,
                    Median = x.Statistics.Median,
                    Max = x.Statistics.Max,
                    AllocatedBytes = x.Memory?.BytesAllocatedPerOperation,
                    Gen0Collects = x.Memory?.Gen0Collections,
                    Gen1Collects = x.Memory?.Gen1Collections,
                    Gen2Collects = x.Memory?.Gen2Collections,
                    CompletedWorkItems = GetMetricValue(x, "CompletedWorkItemCount"),
                    LockContentions = GetMetricValue(x, "LockContentionCount"),
                    BranchInstructions = GetMetricValue(x, "BranchInstructions"),
                    BranchMispredictions = GetMetricValue(x, "BranchMispredictions"),
                    CacheMisses = GetMetricValue(x, "CacheMisses"),
                    NativeAllocatedBytes = GetMetricValue(x, "AllocatedNativeMemoryDescriptor"),
                    NativeMemoryLeak = GetMetricValue(x, "NativeMemoryLeakDescriptor"),
                    ExceptionFrequency = GetMetricValue(x, "ExceptionFrequency"),
                    MethodsJitted = GetMetricValue(x, "MethodsJittedDescriptor"),
                    MethodsTiered = GetMetricValue(x, "MethodsTieredDescriptor"),
                    JitAllocatedMemory = GetMetricValue(x, "JitAllocatedMemoryDescriptor")
                })
                .ToArray();
        }

        private double? GetMetricValue(Benchmark benchmark, string metricName)
        {
            return benchmark
                .Metrics
                ?.FirstOrDefault(x => x.Descriptor.Id == metricName)
                ?.Value;
        }
    }
}
