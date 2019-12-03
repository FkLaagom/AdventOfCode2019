using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
namespace AdventToCode2019
{
    public class _2B
    {
        public static string Result()
        {
            var input = File.ReadLines("2B".InputPath()).First().Split(',').Select(x => int.Parse(x)).ToArray();
            for (int i = 0; i < 100; i++)
                for (int j = 0; j < 100; j++)
                    if (19690720 == getResult(input: input, noun: i, verb: j))
                        return $"{(100 * i + j)}";
            return null;
        }
        private static int getResult(int[] input, int noun, int verb)
        {
            var arr = input.Copy();
            arr[1] = noun;
            arr[2] = verb;
            for (int i = 0; i < arr.Length -3 || arr[i] == 99; i += 4)
                arr[arr[i+3]] = arr[i] == 1 ?
                    arr[arr[i + 1]] + arr[arr[i + 2]]
                    : arr[arr[i + 1]] * arr[arr[i + 2]];
           return arr[0];
        }
    }
}
