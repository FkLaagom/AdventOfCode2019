using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace AdventToCode2019
{
    public class _1A
    {
        private string path = @"C:\Users\larss\Documents\Github\AdventToCode2019\Input\1A.txt";
       public static string Result()
            =>""+File.ReadAllLines("1A".InputPath()).Select(x => int.Parse(x)).Sum(x => x / 3 - 2);
    }
}
