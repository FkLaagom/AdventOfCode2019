using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventToCode2019.Solutions
{
    public class _4A
    {
        public static string Result()
              => ""+Enumerable.Range(245318, 765747 - 245317).Select(n => ("" + n)
                   .Select(d => int.Parse("" + d)).ToArray())
                   .Where(p => (p[5] >= p[4] && p[4] >= p[3] && p[3] >= p[2] && p[2] >= p[1] && p[1] >= p[0])
                   && p.GroupBy(x => x).Any(y => y.Count() >= 2)).Count();
    }
}
