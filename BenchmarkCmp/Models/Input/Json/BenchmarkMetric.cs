namespace BenchmarkCmp.Models.Input.Json
{
    public record BenchmarkMetric(
        double Value,
        BenchmarkMetricDescriptor Descriptor);
}
