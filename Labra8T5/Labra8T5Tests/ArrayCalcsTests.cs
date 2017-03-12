using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labra8T5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8T5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 25.6;

            double actual = array.Sum();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 3.65714285714286;

            double actual = array.Average();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = -4.5;

            double actual = array.Min();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 12.0;

            double actual = array.Max();

            Assert.AreEqual(expected, actual);
        }
    }
}