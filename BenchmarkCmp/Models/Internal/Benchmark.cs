namespace BenchmarkCmp.Models.Internal
{
    public class Benchmark
    {
        public string Name { get; set; }
        public double Mean { get; set; }
        public int? AllocatedBytes { get; set; }
    }
}
