using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFL2021;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL2021.Tests
{
    [TestClass()]
    public class FootBallPlayerTests
    {
        private FootBallPlayer footBallPlayer;

        [TestInitialize()]
        public void startup()
        {
            footBallPlayer = new FootBallPlayer("Rick");
        }
        [TestMethod()]
        public void ConstructorTest()
        {

            Assert.AreEqual("Rick", footBallPlayer.Name);

            Assert.ThrowsException<ArgumentNullException>((() => new FootBallPlayer(null)));
            Assert.ThrowsException<ArgumentException>((() => new FootBallPlayer("")));

        }

        [TestMethod()]
        public void NameTest()
        {
            Assert.AreEqual("Rick", footBallPlayer.Name);

            Assert.ThrowsException<ArgumentException>((() => footBallPlayer.Name = ""));
            Assert.ThrowsException<ArgumentNullException>((() => footBallPlayer.Name = null));
        }

        [TestMethod()]
        public void PriceTest()
        {

            footBallPlayer.Price = 100;
            Assert.AreEqual(100, footBallPlayer.Price);

            footBallPlayer.Price = 0;
            Assert.AreEqual(0,footBallPlayer.Price);

            Assert.ThrowsException<ArgumentOutOfRangeException>((() => footBallPlayer.Price = -1));

        }

        [TestMethod()]
        public void ShirtNumberTest()
        {
            
            footBallPlayer.ShirtNumber = 99;
            Assert.AreEqual(99, footBallPlayer.ShirtNumber);

            footBallPlayer.ShirtNumber = 0;
            Assert.AreEqual(0, footBallPlayer.ShirtNumber);

            Assert.ThrowsException<ArgumentOutOfRangeException>((() => footBallPlayer.ShirtNumber = -1));
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => footBallPlayer.ShirtNumber = 101));
        }
    }
}