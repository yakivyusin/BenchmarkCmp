using BenchmarkCmp.Converters;
using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkAllocatedComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old allocs/op", Order = 2)]
        [TableMemberConverter(typeof(BytesOutputConverter))]
        public override double ValueOld { get; init; }

        [TableMember(DisplayName = "new allocs/op", Order = 3)]
        [TableMemberConverter(typeof(BytesOutputConverter))]
        public override double ValueNew { get; init; }
    }
}
