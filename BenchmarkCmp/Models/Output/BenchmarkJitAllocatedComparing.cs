using BenchmarkCmp.Converters;
using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkJitAllocatedComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old JIT allocs", Order = 2)]
        [TableMemberConverter(typeof(BytesOutputConverter))]
        public override double ValueOld { get; init; }

        [TableMember(DisplayName = "new JIT allocs", Order = 3)]
        [TableMemberConverter(typeof(BytesOutputConverter))]
        public override double ValueNew { get; init; }
    }
}
