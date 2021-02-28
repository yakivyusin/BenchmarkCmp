using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkCacheMissesComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old cache misses/op", Order = 2)]
        public override double ValueOld { get; set; }

        [TableMember(DisplayName = "new cache misses/op", Order = 3)]
        public override double ValueNew { get; set; }
    }
}
