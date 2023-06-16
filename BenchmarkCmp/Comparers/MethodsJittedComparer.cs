using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class MethodsJittedComparer : BaseValueComparer
    {
        public override BenchmarkMethodsJittedComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.MethodsJitted != null).ToArray();
            @new = @new.Where(x => x.MethodsJitted != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkMethodsJittedComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.MethodsJitted.Value,
                        ValueNew = @new.MethodsJitted.Value
                    })
                .ToArray();
        }
    }
}
