using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkGen0Comparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old G0 collects\n/1000 ops", Order = 2)]
        public override double ValueOld { get; set; }

        [TableMember(DisplayName = "new G0 collects\n/1000 ops", Order = 3)]
        public override double ValueNew { get; set; }
    }
}
