using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class BranchMispredictionsComparer : BaseValueComparer
    {
        public override BenchmarkBranchMispredictionsComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.BranchMispredictions != null).ToArray();
            @new = @new.Where(x => x.BranchMispredictions != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkBranchMispredictionsComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.BranchMispredictions.Value,
                        ValueNew = @new.BranchMispredictions.Value
                    })
                .ToArray();
        }
    }
}
