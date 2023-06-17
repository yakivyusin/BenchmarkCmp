using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class MethodsTieredComparer : BaseValueComparer
    {
        public override BenchmarkMethodsTieredComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.MethodsTiered != null).ToArray();
            @new = @new.Where(x => x.MethodsTiered != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkMethodsTieredComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.MethodsTiered.Value,
                        ValueNew = @new.MethodsTiered.Value
                    })
                .ToArray();
        }
    }
}
