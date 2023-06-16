using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class JitAllocatedComparer : BaseValueComparer
    {
        public override BenchmarkJitAllocatedComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.JitAllocatedMemory != null).ToArray();
            @new = @new.Where(x => x.JitAllocatedMemory != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkJitAllocatedComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.JitAllocatedMemory.Value,
                        ValueNew = @new.JitAllocatedMemory.Value
                    })
                .ToArray();
        }
    }
}
