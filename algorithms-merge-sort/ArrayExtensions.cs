using System;
using System.Linq;

namespace algorithms_merge_sort
{
    public static class ArrayExtensions
    {
        public static void PrintElements(this int[] array)
        {
            array.ToList().ForEach(item => Console.Write($"{item} "));
        }
    }
}