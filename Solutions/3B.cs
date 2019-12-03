using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventToCode2019
{
    public class _3B
    {
        public static string Result()
        {
            var inputA = File.ReadLines("3B".InputPath()).First().Split(',');
            var inputB = File.ReadLines("3B".InputPath()).Last().Split(',');
            
            var arrA = GetCordinates(inputA);
            var arrB = GetCordinates(inputB);
            var setB = arrB.ToHashSet();
                        
            var intersections = new HashSet<(int, int)>();

            foreach (var item in arrA)
                if (setB.Contains(item))
                    intersections.Add(item);

            int totalStepMin = int.MaxValue;
            foreach (var item in intersections)
                totalStepMin = (arrA.IndexOf(item) + arrB.IndexOf(item) + 2)
                    .Declare(out int totalsteps) < totalStepMin ? totalsteps : totalStepMin; 

            return ""+totalStepMin;
        }

        private static(int x,int y)[] GetCordinates(string[] instructions)
        {
            var _instructions = instructions.Select(x => (Direction: x[0], Distance: int.Parse(x[1..])));
            var cordinates = new(int,int)[_instructions.Sum(x => x.Distance)];
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
