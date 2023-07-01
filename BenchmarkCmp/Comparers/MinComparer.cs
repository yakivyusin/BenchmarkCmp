using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class MinComparer : BaseValueComparer
    {
        public override BenchmarkMinComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkMinComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.Min,
                        ValueNew = @new.Min
                    })
                .ToArray();
        }
    }
}
