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
    public class OrTests
    {
        [TestMethod()]
        public void OrTest()
        {
            // Initialize objects to test
            Or[] Or = {
                new Or(0, 0),
                new Or(0, 1),
                new Or(1, 0),
                new Or(1, 1)
            };

            // Expected truth table for this object
            bool[] expected = {
                false,
                true,
                true,
                true
            };

            // Iterate through the instance and expected arrays
            for (int i = 0; i < Or.Length; i++)
            {
                Assert.AreEqual(expected[i], Or[i].ToBool());
            }
        }
    }
}