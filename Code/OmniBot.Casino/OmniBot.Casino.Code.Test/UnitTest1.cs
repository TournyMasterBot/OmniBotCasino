using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OmniBot.Casino.Code.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var resultString = Game.Interface.Test.TestMethod();
            Assert.IsTrue(!string.IsNullOrWhiteSpace(resultString) && resultString.Length > 0);
        }
    }
}
