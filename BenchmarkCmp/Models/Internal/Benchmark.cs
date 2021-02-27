namespace BenchmarkCmp.Models.Internal
{
    public class Benchmark
    {
        public string Name { get; set; }
        public double Mean { get; set; }

        #region Memory Diagnoser
        public int? AllocatedBytes { get; set; }
        public double? Gen0Collects { get; set; }
        public double? Gen1Collects { get; set; }
        public double? Gen2Collects { get; set; }
        #endregion

        #region Threading Diagnoser
        public double? CompletedWorkItems { get; set; }
        public double? LockContentions { get; set; }
        #endregion
    }
}
