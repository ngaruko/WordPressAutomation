﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("abc", "abc");
        }


        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("abd", "abd");
        }

    }
}