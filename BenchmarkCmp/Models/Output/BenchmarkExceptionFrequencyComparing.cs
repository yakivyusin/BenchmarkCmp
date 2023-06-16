using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkExceptionFrequencyComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old exceptions/op", Order = 2)]
        public override double ValueOld { get; init; }

        [TableMember(DisplayName = "new exceptions/op", Order = 3)]
        public override double ValueNew { get; init; }
    }
}
