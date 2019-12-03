using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace AdventToCode2019
{
    class Program
    {
        public delegate string ResultDelegate();
        static Dictionary<string, ResultDelegate> ResultDelegates;
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Benchmarks>();
            //ResultDelegates = GetResultDelegates();
            //BenchmarkAll();
            
           // BenchFullDebug();
            Console.ReadLine();
        }
        static void BenchmarkAll()
        {
            foreach (var item in ResultDelegates)
                BenchmarkSingle(prompt: item.Key, method: item.Value);
        }
        static void BenchmarkSingle(ResultDelegate method, string prompt = null)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            string result = method();
            stopwatch.Stop();

            string print = prompt == null ? "" : $"Day: {prompt} ||";
            Console.WriteLine($"{print} Elapsed Millisec: {stopwatch.ElapsedMilliseconds} || Awnser: {result}");
        }
        static void BenchFullDebug()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            string result = _1A.Result();
            stopwatch.Stop();
            Console.WriteLine("1A:" + stopwatch.ElapsedMilliseconds);

            var stopwatch2 = new Stopwatch();
            stopwatch.Start();
            string result2 = _1B.Result();
            stopwatch.Stop();
            Console.WriteLine("1B:" + stopwatch.ElapsedMilliseconds);

            var stopwatch3 = new Stopwatch();
            stopwatch.Start();
            string result3 = _2A.Result();
            stopwatch.Stop();
            Console.WriteLine("2A:" + stopwatch.ElapsedMilliseconds);

            var stopwatch4 = new Stopwatch();
            stopwatch.Start();
            string result4 = _2B.Result();
            stopwatch.Stop();
            Console.WriteLine("2B:" + stopwatch.ElapsedMilliseconds);
        }
        
        static Dictionary<string, ResultDelegate> GetResultDelegates()
        {
            var delegates = new Dictionary<string, ResultDelegate>();
            AppDomain.CurrentDomain.GetAssemblies().ToList()
                .FirstOrDefault(x => x.FullName.StartsWith("AdventToCode2019")).GetTypes()
                .Where(x => x.Name.StartsWith('_')).ToList()
                .ForEach(x =>
                    delegates.Add(x.Name[1..], (ResultDelegate)x.GetMethod("Result")
                    ?.CreateDelegate(typeof(ResultDelegate))));
            delegates.OrderBy(x => x.Key);
            return delegates;
        }

        static Dictionary<string, ResultDelegate> GetResultDelegatesHumanReadable()
        {
            var delegates = new Dictionary<string, ResultDelegate>();
            AppDomain.CurrentDomain.GetAssemblies().ToList()
                .FirstOrDefault(x => x.FullName.StartsWith("AdventToCode2019")).GetTypes()
                .Where(x => x.Name.StartsWith('_')).ToList()
                .ForEach(x => {
                    MethodInfo resultmethod = x.GetMethod("Result");
                    var del = (ResultDelegate)resultmethod?.CreateDelegate(typeof(ResultDelegate));
                    delegates.Add(x.Name[1..], del);
                });
            return delegates;
        }
        

    }
}
