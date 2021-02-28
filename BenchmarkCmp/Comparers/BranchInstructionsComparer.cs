using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class BranchInstructionsComparer : BaseValueComparer
    {
        public override BenchmarkBranchInstructionsComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.BranchInstructions != null).ToArray();
            @new = @new.Where(x => x.BranchInstructions != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkBranchInstructionsComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.BranchInstructions.Value,
                        ValueNew = @new.BranchInstructions.Value
                    })
                .ToArray();
        }
    }
}
