using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class LockContentionsComparer : BaseValueComparer
    {
        public override BenchmarkLockContentionsComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.LockContentions != null).ToArray();
            @new = @new.Where(x => x.LockContentions != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkLockContentionsComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.LockContentions.Value,
                        ValueNew = @new.LockContentions.Value
                    })
                .ToArray();
        }
    }
}
