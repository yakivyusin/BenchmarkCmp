using YetAnotherConsoleTables;

namespace BenchmarkCmp.Converters
{
    public class DeltaOutputConverter : TableMemberConverter<double>
    {
        public override string Convert(double value)
        {
            return $"{value * 100:0.00}%";
        }
    }
}
