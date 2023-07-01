using BenchmarkCmp.Models.Input.Xml;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace BenchmarkCmp.DataLoaders.Concrete
{
    public class XmlDataLoader : IDataLoader
    {
        public Models.Internal.Benchmark[] LoadBenchmarks(string filePath)
        {
            var xml = File.ReadAllText(filePath);
            var serializer = new XmlSerializer(typeof(XmlRootObject));
            var input = (XmlRootObject)serializer.Deserialize(new StringReader(xml));

            return input
                .Benchmarks
                .Select(x => new Models.Internal.Benchmark
                {
                    Name = x.DisplayInfo,
                    Mean = x.Statistics.Mean,
                    Min = x.Statistics.Min,
                    Median = x.Statistics.Median,
                    Max = x.Statistics.Max,
                    AllocatedBytes = x.Memory?.BytesAllocatedPerOperation,
                    Gen0Collects = x.Memory?.Gen0Collections,
                    Gen1Collects = x.Memory?.Gen1Collections,
                    Gen2Collects = x.Memory?.Gen2Collections
                })
                .ToArray();
        }
    }
}
