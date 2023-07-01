using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class MedianComparer : BaseValueComparer
    {
        public override BenchmarkMedianComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkMedianComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.Median,
                        ValueNew = @new.Median
                    })
                .ToArray();
        }
    }
}
