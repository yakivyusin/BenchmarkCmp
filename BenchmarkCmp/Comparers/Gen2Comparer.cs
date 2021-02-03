using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class Gen2Comparer
    {
        public BenchmarkGen2Comparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.Gen2Collects != null).ToArray();
            @new = @new.Where(x => x.Gen2Collects != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkGen2Comparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.Gen2Collects.Value * 1000,
                        ValueNew = @new.Gen2Collects.Value * 1000
                    })
                .ToArray();
        }
    }
}
