using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MergeSort
{
    [TestClass]
    public class MergeSortUnitTests
    {
        [TestMethod]
        public void MergeSortTest()
        {
            double[] testArray = {4.0, 1.0, 3.0};
            double[] correctResult = {1.0, 3.0, 4.0};
            testArray = MergeSortClass.MergeSort(testArray);
            Assert.AreEqual(testArray[0], correctResult[0]);
            Assert.AreEqual(testArray[1], correctResult[1]);
            Assert.AreEqual(testArray[2], correctResult[2]);
        }
    }
}
