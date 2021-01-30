using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkMeanComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old ns/op", Order = 2)]
        public override double ValueOld { get; set; }

        [TableMember(DisplayName = "new ns/op", Order = 3)]
        public override double ValueNew { get; set; }
    }
}
