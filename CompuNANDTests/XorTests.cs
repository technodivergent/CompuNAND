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
    public class XorTests
    {
        [TestMethod()]
        public void XorTest()
        {
            // Initialize objects to test
            Xor[] Xor = {
                new Xor(0, 0),
                new Xor(0, 1),
                new Xor(1, 0),
                new Xor(1, 1)
            };

            // Expected truth table for this object
            bool[] expected = {
                false,
                true,
                true,
                false
            };

            // Iterate through the instance and expected arrays
            for (int i = 0; i < Xor.Length; i++)
            {
                Assert.AreEqual(expected[i], Xor[i].ToBool());
            }
        }
    }
}