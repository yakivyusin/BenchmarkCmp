using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class MeanComparer : BaseValueComparer
    {
        public override BenchmarkMeanComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkMeanComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.Mean,
                        ValueNew = @new.Mean
                    })
                .ToArray();
        }
    }
}
