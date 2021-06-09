
using System;

namespace algorithms_merge_sort
{
    public class MergeSort
    {
        private const int Two = 2;


        public static void Execute(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] array, int firstIndex, int lastIndex)
        {
            if (array is not null && firstIndex < lastIndex && firstIndex >= 0
                 && lastIndex < array.Length && array.Length != 0)
            {
                int middle = ((firstIndex + lastIndex) / Two);

                Sort(array, firstIndex, middle);
                Sort(array, middle + 1, lastIndex);
                Merge(array, firstIndex, middle, lastIndex);
            }

        }

        private static void Merge(int[] array, int firstIndex, int middle, int lastIndex)
        {
            int[] aux = new int[array.Length];
            Array.Copy(array, aux, array.Length);

            int i = firstIndex;
            int j = middle + 1;
            int k = firstIndex;

            while (i <= middle && j <= lastIndex)
            {
                if (aux[i] < aux[j])
                {
                    array[k] = aux[i];
                    i++;
                }
                else
                {
                    array[k] = aux[j];
                    j++;
                }
                k++;
            }


            while (i <= middle)
            {
                array[k] = aux[i];
                i++;
                k++;
            }


            while (j <= lastIndex)
            {
                array[k] = aux[j];
                j++;
                k++;
            }
        }
    }
}