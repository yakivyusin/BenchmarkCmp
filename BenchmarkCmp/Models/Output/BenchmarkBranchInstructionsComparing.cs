using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkBranchInstructionsComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old branch\ninstructions/op", Order = 2)]
        public override double ValueOld { get; set; }

        [TableMember(DisplayName = "new branch\ninstructions/op", Order = 3)]
        public override double ValueNew { get; set; }
    }
}
