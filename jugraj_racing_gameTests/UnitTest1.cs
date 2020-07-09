using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace jugraj_racing_gameTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            jugraj_racing_game.Better better = new jugraj_racing_game.Better();
            int y=better.lastPoint();
            if (y == 680)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            jugraj_racing_game.Better better = new jugraj_racing_game.Better();
            int y = better.moveChetah();
            if (y>0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

    }
}
