using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkGen2Comparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old G2 collects\n/1000 ops", Order = 2)]
        public override double ValueOld { get; init; }

        [TableMember(DisplayName = "new G2 collects\n/1000 ops", Order = 3)]
        public override double ValueNew { get; init; }
    }
}
