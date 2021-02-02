using ByteSizeLib;
using YetAnotherConsoleTables;

namespace BenchmarkCmp.Converters
{
    public class BytesOutputConverter : TableMemberConverter<double>
    {
        public override string Convert(double value)
        {
            if (value == 0)
            {
                return "0";
            }

            var byteSize = ByteSize.FromBytes(value);

            return $"{byteSize.LargestWholeNumberBinaryValue:0.0000} {byteSize.LargestWholeNumberBinarySymbol}";
        }
    }
}
