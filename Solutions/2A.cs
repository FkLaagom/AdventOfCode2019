using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace AdventToCode2019
{
    public class _2A
    {
        public static string Result()
        {
            var input = File.ReadLines("2A".InputPath()).First().Split(',').Select(x => int.Parse(x)).ToArray();
            input[1] = 12;
            input[2] = 2;
            for (int i = 0; i < input.Length - 3 || input[i] == 99; i += 4)
                input[input[i + 3]] = input[i] == 1 ?
                    input[input[i + 1]] + input[input[i + 2]]
                    : input[input[i + 1]] * input[input[i + 2]];
            return $"{input[0]}";
        }
    }  
}
