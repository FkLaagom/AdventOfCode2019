using AdventToCode2019;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benchmark.Benchmarks
{
    [SimpleJob(RunStrategy.ColdStart, targetCount: 5)]
    //[SimpleJob(RunStrategy.Throughput)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn]
    public class BenchAll
    {
        [Benchmark]
        public string Bench1A() => _1A.Result();
        [Benchmark]
        public string Bench1B() => _1B.Result();
        [Benchmark]
        public string Bench2A() => _2A.Result();
        [Benchmark]
        public string Bench2B() => _2B.Result();
        [Benchmark]
        public string Bench3A() => _3A.Result();
        [Benchmark]
        public string Bench3B() => _3B.Result();
        //[Benchmark]
        //public string Bench4A() => _4A.Result();
        //[Benchmark]
        //public string Bench4B() => _4B.Result();
        //[Benchmark]
        //public string Bench5A() => _5A.Result();
        //[Benchmark]
        //public string Bench5B() => _5B.Result();
        //[Benchmark]
        //public string Bench6A() => _6A.Result();
        //[Benchmark]
        //public string Bench6B() => _6B.Result();
        //[Benchmark]
        //public string Bench7A() => _7A.Result();
        //[Benchmark]
        //public string Bench7B() => _7B.Result();
        //[Benchmark]
        //public string Bench8A() => _8A.Result();
        //[Benchmark]
        //public string Bench8B() => _8B.Result();
        //[Benchmark]
        //public string Bench9A() => _9A.Result();
        //[Benchmark]
        //public string Bench9B() => _9B.Result();
        //[Benchmark]
        //public string Bench10A() => _10A.Result();
        //[Benchmark]
        //public string Bench10B() => _10B.Result();
        //[Benchmark]
        //public string Bench11A() => _11A.Result();
        //[Benchmark]
        //public string Bench11B() => _11B.Result();
        //[Benchmark]
        //public string Bench12A() => _12A.Result();
        //[Benchmark]
        //public string Bench12B() => _12B.Result();
        //[Benchmark]
        //public string Bench13A() => _13A.Result();
        //[Benchmark]
        //public string Bench13B() => _13B.Result();
        //[Benchmark]
        //public string Bench14A() => _14A.Result();
        //[Benchmark]
        //public string Bench14B() => _14B.Result();
        //[Benchmark]
        //public string Bench15A() => _15A.Result();
        //[Benchmark]
        //public string Bench15B() => _15B.Result();
        //[Benchmark]
        //public string Bench16A() => _16A.Result();
        //[Benchmark]
        //public string Bench16B() => _16B.Result();
        //[Benchmark]
        //public string Bench17A() => _17A.Result();
        //[Benchmark]
        //public string Bench17B() => _17B.Result();
        //[Benchmark]
        //public string Bench18A() => _18A.Result();
        //[Benchmark]
        //public string Bench18B() => _18B.Result();
        //[Benchmark]
        //public string Bench19A() => _19A.Result();
        //[Benchmark]
        //public string Bench19B() => _19B.Result();
        //[Benchmark]
        //public string Bench20A() => _20A.Result();
        //[Benchmark]
        //public string Bench20B() => _20B.Result();
        //[Benchmark]
        //public string Bench21A() => _21A.Result();
        //[Benchmark]
        //public string Bench21B() => _21B.Result();
        //[Benchmark]
        //public string Bench22A() => _22A.Result();
        //[Benchmark]
        //public string Bench22B() => _22B.Result();
        //[Benchmark]
        //public string Bench23A() => _23A.Result();
        //[Benchmark]
        //public string Bench23B() => _23B.Result();
        //[Benchmark]
        //public string Bench24A() => _24A.Result();
        //[Benchmark]
        //public string Bench24B() => _24B.Result();
    }
}
