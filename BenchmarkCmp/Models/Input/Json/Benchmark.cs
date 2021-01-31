using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkCmp.Models.Input.Json
{
    public class Benchmark
    {
        public string DisplayInfo { get; set; }
        public BenchmarkStatistics Statistics { get; set; }
        public BenchmarkMemory Memory { get; set; }
    }
}
