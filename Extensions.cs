using System;
using System.Collections.Generic;
using System.Text;

namespace AdventToCode2019
{
    public static class Extensions
    {
        public static T[] Copy<T>(this T[] source)
        {
            T[] copy = new T[source.Length];
            Array.Copy(source, copy, source.Length);
            return copy;
        }

        public static T Declare<T>(this T input, out T output)
            => output = input;
    }
}
