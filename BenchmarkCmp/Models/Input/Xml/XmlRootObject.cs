using System.Xml.Serialization;

namespace BenchmarkCmp.Models.Input.Xml
{
    [XmlRoot("Summary", Namespace = "")]
    public class XmlRootObject
    {
        [XmlArrayItem("BenchmarkCase", typeof(BenchmarkCase))]
        public BenchmarkCase[] Benchmarks { get; set; }
    }
}
