using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventToCode2019
{
   public class _Sample
    {
        public static string Result() 
        {
            var inputA = File.ReadLines("3".InputPath()).First().Split(',');
            var inputB = File.ReadLines("3".InputPath()).Last().Split(',');
            var arrA = GetCordinateArr(inputA);
            var setB = GetCordinateSet(inputB);
            var intersections = new HashSet<(int x, int y)>();
            foreach (var item in arrA)
                if (setB.Contains(item))
                    intersections.Add(item);
            return "" + intersections.Select(m => Math.Abs(m.x) + Math.Abs(m.y)).Min(x => x);
        }

        private static HashSet<(int x,int y)> GetCordinateSet(string[] instructions)
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

        private static (int x, int y)[] GetCordinateArr(string[] instructions)
        {
            var _instructions = instructions.Select(x => (Direction: x[0], Distance: int.Parse(x[1..])));
            var cordinates = new (int, int)[_instructions.Sum(x => x.Distance)];
            int _x = 0;
            int _y = 0;
            int cordinateIndex = 0;
            foreach (var instruction in _instructions)
                for (int i = 0; i < instruction.Distance; i++)
                {
                    if (instruction.Direction == 'U') _y++;
                    else if (instruction.Direction == 'D') _y--;
                    else if (instruction.Direction == 'L') _x--;
                    else _x++;

                    cordinates[cordinateIndex] = (_x, _y);
                    cordinateIndex++;
                }
            return cordinates;
        }
    }
}
