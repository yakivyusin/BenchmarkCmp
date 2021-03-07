using BenchmarkCmp.Converters;
using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkNativeAllocatedComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old native allocs/op", Order = 2)]
        [TableMemberConverter(typeof(BytesOutputConverter))]
        public override double ValueOld { get; init; }

        [TableMember(DisplayName = "new native allocs/op", Order = 3)]
        [TableMemberConverter(typeof(BytesOutputConverter))]
        public override double ValueNew { get; init; }
    }
}
