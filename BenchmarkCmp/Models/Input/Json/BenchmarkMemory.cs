namespace BenchmarkCmp.Models.Input.Json
{
    public record BenchmarkMemory(
        int BytesAllocatedPerOperation,
        double Gen0Collections,
        double Gen1Collections,
        double Gen2Collections);
}
