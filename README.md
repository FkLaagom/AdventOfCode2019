# AdventOfCode2019 


## Solution Benchmark
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-6200U CPU 2.30GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT  [AttachedDebugger]
  Job-XKNPZN : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

IterationCount=50  RunStrategy=ColdStart  

```
|  Method |        Mean |      Error |     StdDev |      Median |         Min |         Max |
|-------- |------------:|-----------:|-----------:|------------:|------------:|------------:|
| Bench1A |    479.9 us |   593.4 us | 1,198.8 us |    299.9 us |    220.1 us |  8,775.7 us |
| Bench1B |    531.3 us |   618.3 us | 1,248.9 us |    319.8 us |    244.2 us |  9,156.0 us |
| Bench2A |    493.3 us |   643.3 us | 1,299.4 us |    298.2 us |    223.0 us |  9,484.7 us |
| Bench2B |  4,480.4 us |   848.9 us | 1,714.7 us |  4,187.9 us |  3,539.1 us | 16,033.7 us |
| Bench3A | 60,491.0 us | 2,840.2 us | 5,737.4 us | 60,248.8 us | 51,321.0 us | 91,889.9 us |
| Bench3B | 48,957.9 us | 3,472.1 us | 7,013.8 us | 49,588.7 us | 33,854.0 us | 76,428.1 us |
