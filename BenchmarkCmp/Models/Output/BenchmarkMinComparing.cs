using BenchmarkCmp.Converters;
using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkMinComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old min time/op", Order = 2)]
        [TableMemberConverter(typeof(TimeOutputConverter))]
        public override double ValueOld { get; init; }

        [TableMember(DisplayName = "new min time/op", Order = 3)]
        [TableMemberConverter(typeof(TimeOutputConverter))]
        public override double ValueNew { get; init; }
    }
}
