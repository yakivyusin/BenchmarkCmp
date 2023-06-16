using YetAnotherConsoleTables.Attributes;

namespace BenchmarkCmp.Models.Output
{
    public class BenchmarkMethodsJittedComparing : BenchmarkComparingBase
    {
        [TableMember(DisplayName = "old methods JITted", Order = 2)]
        public override double ValueOld { get; init; }

        [TableMember(DisplayName = "new methods JITted", Order = 3)]
        public override double ValueNew { get; init; }
    }
}
