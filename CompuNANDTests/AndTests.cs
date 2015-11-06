using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompuNAND;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND.Tests
{
    [TestClass()]
    public class AndTests
    {
        [TestMethod()]
        public void AndTest()
        {
            // Initialize objects to test
            And[] And = {
                new And(0, 0),
                new And(0, 1),
                new And(1, 0),
                new And(1, 1)
            };

            // Expected truth table for this object
            bool[] expected = {
                false,
                false,
                false,
                true
            };

            // Iterate through the instance and expected arrays
            for (int i = 0; i < And.Length; i++)
            {
                Assert.AreEqual(expected[i], And[i].ToBool());
            }
        }
    }
}