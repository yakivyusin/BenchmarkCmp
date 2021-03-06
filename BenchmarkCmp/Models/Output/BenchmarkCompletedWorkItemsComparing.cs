using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkCompletedWorkItemsComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old work items/op", Order = 2)]
        public override double ValueOld { get; init; }

        [TableMember(DisplayName = "new work items/op", Order = 3)]
        public override double ValueNew { get; init; }
    }
}
