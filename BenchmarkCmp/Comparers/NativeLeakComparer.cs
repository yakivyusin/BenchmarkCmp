using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class NativeLeakComparer : BaseValueComparer
    {
        public override BenchmarkNativeLeakComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.NativeMemoryLeak != null).ToArray();
            @new = @new.Where(x => x.NativeMemoryLeak != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkNativeLeakComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.NativeMemoryLeak.Value,
                        ValueNew = @new.NativeMemoryLeak.Value
                    })
                .ToArray();
        }
    }
}
