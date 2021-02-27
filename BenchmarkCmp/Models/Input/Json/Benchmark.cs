namespace BenchmarkCmp.Models.Input.Json
{
    public class Benchmark
    {
        public string DisplayInfo { get; set; }
        public BenchmarkStatistics Statistics { get; set; }
        public BenchmarkMemory Memory { get; set; }
        public BenchmarkMetric[] Metrics { get; set; }
    }
}
