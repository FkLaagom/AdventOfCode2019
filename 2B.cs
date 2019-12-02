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
            var input = File.ReadLines("2B.txt").First().Split(',').Select(x => int.Parse(x)).ToArray();

            for (int i = 0; i < 100; i++)
                for (int j = 0; j < 100; j++)
                {
                    int result = getResult(input: input, noun: i, verb: j);
                    if (result == 19690720)
                        return $"{(100 * i + j)}";
                }
            return null;
        }
        private static int getResult(int[] input, int noun, int verb)
        {
            var arr = input.Copy();
            arr[1] = noun;
            arr[2] = verb;
            for (int i = 0; i < arr.Length; i += 4)
            {
                if (arr[i] == 1)
                    arr[arr[i + 3]] = arr[arr[i + 1]] + arr[arr[i + 2]];
                else if (arr[i] == 2)
                    arr[arr[i + 3]] = arr[arr[i + 1]] * arr[arr[i + 2]];
                else if (arr[i] == 99)
                    break;
                else Console.WriteLine("ERROR");
            }
            return arr[0];
        }
    }
}
