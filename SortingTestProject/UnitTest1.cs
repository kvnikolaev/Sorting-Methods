using System;
using Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InitTestMethod()
        {
            Sorting.Program.Init(5000); //lol
        }

        [TestMethod]
        public void InitDiagonalTestMethod()
        {
            Sorting.Program.InitDiagonal(5000);
        }

    }
}
