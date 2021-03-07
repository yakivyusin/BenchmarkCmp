using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class NativeAllocatedComparer : BaseValueComparer
    {
        public override BenchmarkNativeAllocatedComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.NativeAllocatedBytes != null).ToArray();
            @new = @new.Where(x => x.NativeAllocatedBytes != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkNativeAllocatedComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.NativeAllocatedBytes.Value,
                        ValueNew = @new.NativeAllocatedBytes.Value
                    })
                .ToArray();
        }
    }
}
