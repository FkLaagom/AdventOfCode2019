using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace AdventToCode2019
{
    [SimpleJob(RuntimeMoniker.NetCoreApp30)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn]
    public class Benchmarks
    {
        [Benchmark]
        public string Day1a() => _1A.Result();

        //[Benchmark]
        //public string Day1b() => _1B.Result();

        //[Benchmark]
        //public string Day2a() => _2A.Result();

        //[Benchmark]
        //public string Day2b() => _2B.Result();

    }
}
