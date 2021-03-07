using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkGen1Comparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old G1 collects\n/1000 ops", Order = 2)]
        public override double ValueOld { get; init; }

        [TableMember(DisplayName = "new G1 collects\n/1000 ops", Order = 3)]
        public override double ValueNew { get; init; }
    }
}
