using System;
using System.Linq;
namespace algorithms_merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 6, 3, 9, 5, 2, 7, 8, 4, 1 };
            MergeSort.Execute(array);
            array.PrintElements();
        }
    }
}
