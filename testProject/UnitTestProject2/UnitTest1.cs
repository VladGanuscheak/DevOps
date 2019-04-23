using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using testProject;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()        {
            Functionality functionality = new Functionality();

            Assert.AreEqual(functionality.Add(2, 2), 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Functionality functionality = new Functionality();

            Assert.AreEqual(functionality.Add(2, 3), 6);
        }
    }
}
