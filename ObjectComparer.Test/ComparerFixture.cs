using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectComparer.Test.TestClass;

namespace ObjectComparer.Test
{
    [TestClass]
    public class ComparerFixture
    {
        Student first = new Student
        {
            Name = "Pramod",
            Marks = new[] { 1, 3, 5 }
        };

        Student second = new Student
        {
            Name = "Pramod",
            Marks = new[] { 1, 3, 5 }
        };

        [TestMethod]
        public void Null_values_are_similar_test()
        {
            string first = null, second = null;
            Assert.IsTrue(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void String_values_are_similar_test()
        {
            Assert.IsTrue(Comparer.AreSimilar("Test1", "Test1"));
        }

        [TestMethod]
        public void Null_values_are_not_similar_test()
        {
            string first = "Test", second = null;
            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void Int_values_are_similar_test()
        {
            Assert.IsTrue(Comparer.AreSimilar(1, 1));
        }

        [TestMethod]
        public void Float_values_are_similar_test()
        {
            Assert.IsTrue(Comparer.AreSimilar(1.43, 1.43));
        }

        [TestMethod]
        public void Float_values_are_not_similar_test()
        {
            Assert.IsFalse(Comparer.AreSimilar(1.55, 1));
        }

        [TestMethod]
        public void StudentClass_values_are_similar_test()
        {
            Assert.IsFalse(Comparer.AreSimilar(first, second));
        }

        [TestMethod]
        public void IntArray_values_are_similar_test()
        {
            int[] arr1 = new[] { 1, 2, 4, 5 };
            int[] arr2 = new[] { 1, 2, 5, 4 };
            Assert.IsFalse(Comparer.AreSimilar(arr1, arr2));
        }

    }
}
