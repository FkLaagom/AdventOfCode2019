﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventToCode2019
{
    class _2A
    {
        public static string Result()
        {
            var input = File.ReadLines("2A.txt").First().Split(',').Select(x => int.Parse(x)).ToArray();
            input[1] = 12;
            input[2] = 2;
            for (int i = 0; i < input.Length - 3; i += 4)
            {
                if (input[i] == 99) 
                    break;
                input[input[i + 3]] = input[i]
                      == 1 ? input[input[i + 1]] + input[input[i + 2]]
                      : input[input[i + 1]] * input[input[i + 2]];
            }
            
            return $"{input[0]}";
        }

    }  
        
}