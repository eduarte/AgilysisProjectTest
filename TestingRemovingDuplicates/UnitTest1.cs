using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgilysysProject;

namespace TestingRemovingDuplicates
{
    [TestClass]
    public class RemovingDuplicatesFromArrayTest
    {

        [TestMethod]
        public void TestRemoveDuplicatesWithEmptyArrayShouldReturnAnEmptyArray()
        {
            int[] array = { };
            int[] expected_array = { };

            var clean_array = Agilysys.remove_duplicates(array);

            CollectionAssert.AreEqual(expected_array,clean_array);
        }

        [TestMethod]
        public void TestRemoveDuplicatesWithSixElementsShouldReturnThreeUniqueValues()
        {
            int[] array = {1,2,3,1,2,3};
            int[] expected_array = {1,2,3};

            var clean_array = Agilysys.remove_duplicates(array);

            CollectionAssert.AreEqual(expected_array, clean_array);
        }

        [TestMethod]
        public void TestRemoveDuplicatesWithSixElementsShouldReturnSixUniqueValues()
        {
            int[] array = { 1, -1, 2, -2, 3, -3 };
            int[] expected_array = { 1, -1, 2, -2, 3, -3 };

            var clean_array = Agilysys.remove_duplicates(array);

            CollectionAssert.AreEqual(expected_array, clean_array);
        }
    }
}
