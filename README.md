# dotnet-benchmarkcmp [![NuGet](https://img.shields.io/nuget/v/BenchmarkCmp.svg)](https://www.nuget.org/packages/BenchmarkCmp/) [![Made in Ukraine](https://img.shields.io/badge/made_in-ukraine-ffd700.svg?labelColor=0057b7)](https://stand-with-ukraine.pp.ua)

Inspired by `go-benchcmp`, `dotnet-benchmarkcmp` displays performance changes between benchmarks.

`benchmarkcmp` parses the output of two `BenchmarkDotNet` benchmark runs, correlates the results per benchmark (based on name), and displays the deltas.

## Getting started

### Installation
To install the tool, use `dotnet tool install` command:

```
dotnet tool install -g BenchmarkCmp
```

### Use
To measure the performance impact of a change, use `BenchmarkDotNet` to run benchmarks before / after the change and save artifacts. Then feed the benchmark artifacts (check Supported exporters section to see supported artifacts) to `benchmarkcmp`:

```
dotnet benchmarkcmp old.json new.json
```

`benchmarkcmp` will summarize and display the performance changes, in a format like this:
```
 benchmark                     | old time/op | new time/op | delta
-------------------------------+-------------+-------------+--------
 SimpleBenchmark.A: DefaultJob | 1,210 s     | 1,108 s     | -8,44%

 benchmark                     | old allocs | new allocs | delta
-------------------------------+------------+------------+-------
 SimpleBenchmark.A: DefaultJob | 0          | 0          | ~

 benchmark                     | old G0 collects | new G0 collects | delta
                               | per 1k ops      | per 1k ops      |
-------------------------------+-----------------+-----------------+-------
 SimpleBenchmark.A: DefaultJob | 0               | 0               | ~

 benchmark                     | old G1 collects | new G1 collects | delta
                               | per 1k ops      | per 1k ops      |
-------------------------------+-----------------+-----------------+-------
 SimpleBenchmark.A: DefaultJob | 0               | 0               | ~

 benchmark                     | old G2 collects | new G2 collects | delta
                               | per 1k ops      | per 1k ops      |
-------------------------------+-----------------+-----------------+-------
 SimpleBenchmark.A: DefaultJob | 0               | 0               | ~
```

## Supported data
* Base Statistics
  * Min / median / mean / max run time
* Memory Diagnoser
  * Allocated memory
  * Gen 0, 1, 2 allocation
* Threading Diagnoser
  * Completed work items
  * Lock contentions
* Native Memory Profiler
  * Allocated native memory
  * Native memory leak
* Hardware Counter Diagnoser
  * Branch instructions
  * Branch mispredictions
  * Cache misses
* Exception Diagnoser
  * Exception frequency
* JIT Stats Diagnoser
  * Amount of JITted methods
  * Amount of tiered methods
  * JIT allocated memory

## Supported exporters
* JsonExporter.Brief
* JsonExporter.Full
* XmlExporter.Brief
* XmlExporter.Full
