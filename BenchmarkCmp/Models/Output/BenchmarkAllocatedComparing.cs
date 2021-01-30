using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkAllocatedComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old allocs", Order = 2)]
        public override double ValueOld { get; set; }

        [TableMember(DisplayName = "new allocs", Order = 3)]
        public override double ValueNew { get; set; }
    }
}
