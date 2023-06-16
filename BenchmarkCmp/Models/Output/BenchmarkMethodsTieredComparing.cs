using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkMethodsTieredComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old methods tiered", Order = 2)]
        public override double ValueOld { get; init; }

        [TableMember(DisplayName = "new methods tiered", Order = 3)]
        public override double ValueNew { get; init; }
    }
}
