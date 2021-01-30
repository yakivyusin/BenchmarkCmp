using BenchmarkCmp.Converters;
using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public abstract class BenchmarkComparingBase
    {
        [TableMember(DisplayName = "benchmark", Order = 1)]
        public string Benchmark { get; set; }

        public abstract double ValueOld { get; set; }

        public abstract double ValueNew { get; set; }

        [TableMember(DisplayName = "delta", Order = 4)]
        [TableMemberConverter(typeof(DeltaOutputConverter))]
        public double Delta => (ValueNew - ValueOld) / ValueOld;
    }
}
