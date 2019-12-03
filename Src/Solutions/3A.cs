using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventToCode2019
{
   public class _3A
    {
        public static string Result() 
        {
            var inputA = File.ReadLines("3".InputPath()).First().Split(',');
            var inputB = File.ReadLines("3".InputPath()).Last().Split(',');
            var setA = GetCordinates(inputA);
            var setB = GetCordinates(inputB);
            var intersections = new HashSet<(int x, int y)>();
            foreach (var item in setA)
                if (setB.Contains(item))
                    intersections.Add(item);
            return "" + intersections.Select(m => Math.Abs(m.x) + Math.Abs(m.y)).Min(x => x);
        }

        private static HashSet<(int x,int y)> GetCordinates(string[] instructions)
        {
            var set = new HashSet<(int,int)>();
            int x = 0;
            int y = 0;
            foreach (var item in instructions)
            {
                char direction = item[0];
                int stepCount = int.Parse(item[1..]);
                for (int i = 0; i < stepCount; i++)
                {
                    if (direction == 'U') y++;
                    else if (direction == 'D') y--;
                    else if (direction == 'L') x--;
                    else if (direction == 'R') x++;
                    set.Add((x, y));
                }
            }
            return set;
        }
    }
}
