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
    public class NorTests
    {
        [TestMethod()]
        public void NorTest()
        {
            // Initialize objects to test
            Nor[] Nor = {
                new CompuNAND.Nor(0, 0),
                new CompuNAND.Nor(0, 1),
                new CompuNAND.Nor(1, 0),
                new CompuNAND.Nor(1, 1)
            };

            // Expected truth table for this object
            bool[] expected = {
                true,
                false,
                false,
                false
            };

            // Iterate through the instance and expected arrays
            for (int i = 0; i < Nor.Length; i++)
            {
                Assert.AreEqual(expected[i], Nor[i].ToBool());
            }
        }
    }
}