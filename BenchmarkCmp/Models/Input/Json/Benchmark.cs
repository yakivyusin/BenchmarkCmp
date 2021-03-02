namespace BenchmarkCmp.Models.Input.Json
{
    public record Benchmark(
        string DisplayInfo,
        BenchmarkStatistics Statistics,
        BenchmarkMemory Memory,
        BenchmarkMetric[] Metrics);
}
