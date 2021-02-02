using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class Gen0Comparer
    {
        public BenchmarkGen0Comparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.Gen0Collects != null).ToArray();
            @new = @new.Where(x => x.Gen0Collects != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkGen0Comparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.Gen0Collects.Value * 1000,
                        ValueNew = @new.Gen0Collects.Value * 1000
                    })
                .ToArray();
        }
    }
}
