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
            ResultDelegates = GetResultDelegates();
            ToggleMenue();
            Console.SetCursorPosition(0, 5);
            Menu:
            Console.WriteLine("N/A\t Run the latest solution\r\n--a\tRuns all \r\n--q\t Quit");
            var input = Console.ReadLine();
            if (input == "")
                BenchmarkSingle(ResultDelegates.LastOrDefault().Value, ResultDelegates.LastOrDefault().Key);
            else if (input == "--a")
                BenchmarkAll();
            else if (input == "--q")
                Environment.Exit(0);
            else
                BenchmarkAll();
            goto Menu;
        }

        private static void ToggleMenue()
        {
            Menu:
            Console.WriteLine("\n\n\n\n\nN/A\tRun the latest solution\r\n--a\tRuns all \r\n--q\tQuit");
            var input = Console.ReadLine();
            if (input == "")
            {
                Console.Clear();
                BenchmarkSingle(ResultDelegates.LastOrDefault().Value, ResultDelegates.LastOrDefault().Key);
                Console.WriteLine("Press any key to continue..");
                Console.ReadLine();
                Console.Clear();
            }
            else if (input == "--a")
            {
                Console.Clear();
                BenchmarkAll();
                Console.WriteLine("Press any key to continue..");
                Console.ReadLine();
                Console.Clear();
            }
            else if (input == "--q")
                Environment.Exit(0);
            else Console.Clear();
            goto Menu;
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
    }
}
