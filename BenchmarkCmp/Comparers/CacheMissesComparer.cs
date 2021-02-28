using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class CacheMissesComparer : BaseValueComparer
    {
        public override BenchmarkCacheMissesComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.CacheMisses != null).ToArray();
            @new = @new.Where(x => x.CacheMisses != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkCacheMissesComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.CacheMisses.Value,
                        ValueNew = @new.CacheMisses.Value
                    })
                .ToArray();
        }
    }
}
