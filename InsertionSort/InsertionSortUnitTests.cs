using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsertionSort
{
    [TestClass]
    public class InsertionSortUnitTests
    {
        [TestMethod]
        public void InsertionSortTest()
        {
            double[] testArray = { 12.0, 10.0, 1.0, 3.0 };
            double[] correctResult = { 1.0, 3.0, 10.0, 12.0 };
            testArray = InsertionSortClass.InsertionSort(testArray);
            Assert.AreEqual(testArray[0], correctResult[0]);
            Assert.AreEqual(testArray[1], correctResult[1]);
            Assert.AreEqual(testArray[2], correctResult[2]);
        }
    }
}
