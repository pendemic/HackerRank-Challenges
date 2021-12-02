using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeautifulDayAtTheMovies;

namespace BeautifulDayTests
{
    [TestClass]
    public class BeautifulDayTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            BeautifulDay bd = new BeautifulDay();
            int i = 20, j = 23, k = 6;
            int res = bd.beautifulDays(i, j, k);
            Assert.AreEqual(res, 2);
        }
    }
}
