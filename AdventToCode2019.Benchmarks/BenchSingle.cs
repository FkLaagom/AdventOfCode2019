using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System;
using System.Collections.Generic;
using System.Text;
using AdventToCode2019;
using AdventToCode2019.Solutions;

namespace Benchmark
{
    [SimpleJob(RunStrategy.ColdStart, targetCount: 5)]
    //[SimpleJob(RunStrategy.Throughput)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn]
    public class BenchSingle
    {
        [Benchmark]
        public string Bench1A() => _1A.Result();
    }
}
