using BenchmarkCmp.Converters;
using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public abstract class BenchmarkComparingBase
    {
        [TableMember(DisplayName = "benchmark", Order = 1)]
        public string Benchmark { get; init; }

        public abstract double ValueOld { get; init; }

        public abstract double ValueNew { get; init; }

        [TableMember(DisplayName = "delta", Order = 4)]
        [TableMemberConverter(typeof(DeltaOutputConverter))]
        public double Delta => ValueOld != 0 ?
            (ValueNew - ValueOld) / ValueOld :
            0;
    }
}
