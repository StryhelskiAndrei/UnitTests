using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalc.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum10and20_returned30()
        {
            int x = 10;
            int y = 20;
            int expected = 30;


            MyCalc calc = new MyCalc();
            int actual = calc.Sum(x, y);


            Assert.AreEqual(expected, actual);
        }
    }
}
