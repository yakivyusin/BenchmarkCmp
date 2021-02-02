namespace BenchmarkCmp.Models.Input.Json
{
    public class BenchmarkMemory
    {
        public int BytesAllocatedPerOperation { get; set; }
        public double Gen0Collections { get; set; }
        public double Gen1Collections { get; set; }
        public double Gen2Collections { get; set; }
    }
}
