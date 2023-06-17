using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;
using System.Linq;

namespace BenchmarkCmp.Comparers
{
    public class ExceptionFrequencyComparer : BaseValueComparer
    {
        public override BenchmarkExceptionFrequencyComparing[] Compare(Benchmark[] old, Benchmark[] @new)
        {
            old = old.Where(x => x.ExceptionFrequency != null).ToArray();
            @new = @new.Where(x => x.ExceptionFrequency != null).ToArray();

            return old
                .Join(@new,
                    old => old.Name,
                    @new => @new.Name,
                    (old, @new) => new BenchmarkExceptionFrequencyComparing
                    {
                        Benchmark = old.Name,
                        ValueOld = old.ExceptionFrequency.Value,
                        ValueNew = @new.ExceptionFrequency.Value
                    })
                .ToArray();
        }
    }
}
