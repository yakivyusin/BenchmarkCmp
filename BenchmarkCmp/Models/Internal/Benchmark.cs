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

        #region Hardware Counters Diagnoser
        public double? BranchInstructions { get; set; }
        public double? BranchMispredictions { get; set; }
        public double? CacheMisses { get; set; }
        #endregion

        #region Native Memory Diagnoser
        public int? NativeAllocatedBytes { get; set; }
        public int? NativeMemoryLeak { get; set; }
        #endregion
    }
}
