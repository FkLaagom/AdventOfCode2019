using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventToCode2019.Solutions
{
    public class _5A
    {
        public static string Result()
        {
            var input = File.ReadLines("2".InputPath()).First().Split(',').Select(x => int.Parse(x)).ToArray();

            int i = 0;
            while(i < input.Length)
            {
                
                int opCode = input[i];
                switch (opCode)
                {
                   case 1:
                    {
                        i += 4;
                        break;
                    }
                    case 2:
                    {
                        i += 4;
                        break;
                    }
                    case 3:
                    {
                        i += 2;
                        break;
                    }
                    case 4:
                    {
                        i += 2;
                        break;
                    }
                }
            }
            return $"";
        }
    }
}
