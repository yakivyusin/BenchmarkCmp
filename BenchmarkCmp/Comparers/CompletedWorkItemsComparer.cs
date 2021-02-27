using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class CompletedWorkItemsComparer : BaseValueComparer
    {
        public override BenchmarkCompletedWorkItemsComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.CompletedWorkItems != null).ToArray();
            @new = @new.Where(x => x.CompletedWorkItems != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkCompletedWorkItemsComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.CompletedWorkItems.Value,
                        ValueNew = @new.CompletedWorkItems.Value
                    })
                .ToArray();
        }
    }
}
