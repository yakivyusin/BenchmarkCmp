using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkGen2Comparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old G2 collects\nper 1k ops", Order = 2)]
        public override double ValueOld { get; set; }

        [TableMember(DisplayName = "new G2 collects\nper 1k ops", Order = 3)]
        public override double ValueNew { get; set; }
    }
}
