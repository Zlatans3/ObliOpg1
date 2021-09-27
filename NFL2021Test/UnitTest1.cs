using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFL2021;
using System.Collections.Generic;

namespace NFL2021Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new FootBallPlayer(null));
        }
    }
}
