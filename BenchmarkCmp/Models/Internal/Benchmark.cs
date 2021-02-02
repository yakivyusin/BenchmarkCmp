namespace BenchmarkCmp.Models.Internal
{
    public class Benchmark
    {
        public string Name { get; set; }
        public double Mean { get; set; }
        public int? AllocatedBytes { get; set; }
        public double? Gen0Collects { get; set; }
        public double? Gen1Collects { get; set; }
        public double? Gen2Collects { get; set; }
    }
}
