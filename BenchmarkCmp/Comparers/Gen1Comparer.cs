using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class Gen1Comparer
    {
        public BenchmarkGen1Comparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.Gen1Collects != null).ToArray();
            @new = @new.Where(x => x.Gen1Collects != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkGen1Comparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.Gen1Collects.Value * 1000,
                        ValueNew = @new.Gen1Collects.Value * 1000
                    })
                .ToArray();
        }
    }
}
