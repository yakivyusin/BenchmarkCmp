using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkBranchMispredictionsComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old branch\nmispredictions/op", Order = 2)]
        public override double ValueOld { get; set; }

        [TableMember(DisplayName = "new branch\nmispredictions/op", Order = 3)]
        public override double ValueNew { get; set; }
    }
}
