using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class MaxComparer : BaseValueComparer
    {
        public override BenchmarkMaxComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkMaxComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.Max,
                        ValueNew = @new.Max
                    })
                .ToArray();
        }
    }
}
