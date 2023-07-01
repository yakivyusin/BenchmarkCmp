namespace BenchmarkCmp.Models.Input.Xml
{
    public class BenchmarkCase
    {
        public string DisplayInfo { get; init; }
        public BenchmarkStatistics Statistics { get; init; }
        public BenchmarkMemory Memory { get; init; }
    }
}
