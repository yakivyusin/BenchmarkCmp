namespace BenchmarkCmp.Models.Internal
{
    public class Benchmark
    {
        public string Name { get; init; }
        public double Mean { get; init; }

        #region Memory Diagnoser
        public double? AllocatedBytes { get; init; }
        public double? Gen0Collects { get; init; }
        public double? Gen1Collects { get; init; }
        public double? Gen2Collects { get; init; }
        #endregion

        #region Threading Diagnoser
        public double? CompletedWorkItems { get; init; }
        public double? LockContentions { get; init; }
        #endregion

        #region Hardware Counters Diagnoser
        public double? BranchInstructions { get; init; }
        public double? BranchMispredictions { get; init; }
        public double? CacheMisses { get; init; }
        #endregion

        #region Native Memory Diagnoser
        public double? NativeAllocatedBytes { get; init; }
        public double? NativeMemoryLeak { get; init; }
        #endregion

        #region Exception Diagnoser
        public double? ExceptionFrequency { get; init; }
        #endregion
    }
}
