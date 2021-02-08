using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class AllocatedComparer : BaseValueComparer
    {
        public override BenchmarkAllocatedComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.AllocatedBytes != null).ToArray();
            @new = @new.Where(x => x.AllocatedBytes != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkAllocatedComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.AllocatedBytes.Value,
                        ValueNew = @new.AllocatedBytes.Value
                    })
                .ToArray();
        }
    }
}
