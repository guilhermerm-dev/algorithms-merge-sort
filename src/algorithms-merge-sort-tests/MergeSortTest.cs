using algorithms_merge_sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace algorithms_merge_sort_tests
{
    [TestClass]
    public class MergeSortTest
    {
        [TestMethod]
        public void ShouldValidateMergeSort()
        {
            int[] array = { 10, 6, 3, 9, 5, 2, 7, 8, 4, 1 };
            MergeSort.Execute(array);
            Assert.AreEqual(1, array[0]);
            Assert.AreEqual(10, array[array.Length - 1]);
        }
    }
}
