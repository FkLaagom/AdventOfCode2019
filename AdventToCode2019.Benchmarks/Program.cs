using Benchmark.Benchmarks;
using BenchmarkDotNet.Running;
using System;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BenchAll>();
            //var summary = BenchmarkRunner.Run<BenchSingle>();
        }
    }
}
