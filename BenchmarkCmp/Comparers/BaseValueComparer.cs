using BenchmarkCmp.Models.Internal;
using BenchmarkCmp.Models.Output;

namespace BenchmarkCmp.Comparers
{
    public abstract class BaseValueComparer
    {
        public abstract BenchmarkComparingBase[] Compare(Benchmark[] old, Benchmark[] @new);
    }
}
