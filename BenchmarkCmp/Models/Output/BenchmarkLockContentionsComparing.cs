using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkLockContentionsComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old contentions/op", Order = 2)]
        public override double ValueOld { get; init; }

        [TableMember(DisplayName = "new contentions/op", Order = 3)]
        public override double ValueNew { get; init; }
    }
}
