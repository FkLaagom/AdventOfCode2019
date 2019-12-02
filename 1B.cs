using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace AdventToCode2019
{
    class _1B
    {
        public static string Result()
           => "" + File.ReadAllLines("1B.txt").Select(x => int.Parse(x))
             .Sum(x => { int t = 0; while ((x = x / 3 - 2) > 0) t += x; return t; });
    }
}
