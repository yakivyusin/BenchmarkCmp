using YetAnotherConsoleTables;

namespace BenchmarkCmp.Converters
{
    public class TimeOutputConverter : TableMemberConverter<double>
    {
        private static readonly string[] _units = new[] { "ns", "us", "ms", "s" };

        public override string Convert(double value)
        {
            if (value == 0)
            {
                return "0";
            }

            var unitIndex = 0;

            while (value >= 1000 && unitIndex < _units.Length - 1)
            {
                value /= 1000;
                unitIndex++;
            }

            return $"{value:0.000} {_units[unitIndex]}";
        }
    }
}
