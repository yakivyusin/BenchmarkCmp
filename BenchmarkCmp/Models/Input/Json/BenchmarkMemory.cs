namespace BenchmarkCmp.Models.Input.Json
{
    public record BenchmarkMemory(
        double BytesAllocatedPerOperation,
        double Gen0Collections,
        double Gen1Collections,
        double Gen2Collections);
}
