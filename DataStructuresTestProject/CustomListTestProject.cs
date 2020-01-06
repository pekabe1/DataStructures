using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresTestProject
{
    [TestClass]
    public class CustomListTestProject
    {
        [TestMethod]
        public void AddInt_returnsTypeOfInt()
        {
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);

        }
    }
}
