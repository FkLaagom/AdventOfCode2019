using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace AdventToCode2019
{
    public class _1A
    {
       public static string Result()
            =>""+File.ReadAllLines("1".InputPath()).Select(x => int.Parse(x)).Sum(x => x / 3 - 2);
    }
}
