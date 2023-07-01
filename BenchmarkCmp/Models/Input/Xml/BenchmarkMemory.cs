namespace BenchmarkCmp.Models.Input.Xml
{
    public class BenchmarkMemory
    {
        public double BytesAllocatedPerOperation { get; init; }
        public double Gen0Collections { get; init; }
        public double Gen1Collections { get; init; }
        public double Gen2Collections { get; init; }
    }
}
