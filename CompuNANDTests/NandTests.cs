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
    public class NandTests
    {
        [TestMethod()]
        public void NandTest()
        {
            // Initialize objects to test
            Nand[] Nand = {
                new Nand(0, 0),
                new Nand(0, 1),
                new Nand(1, 0),
                new Nand(1, 1)
            };

            // Expected truth table for this object
            bool[] expected = {
                true,
                true,
                true,
                false
            };

            // Iterate through the instance and expected arrays
            for (int i = 0; i < Nand.Length; i++)
            {
                Assert.AreEqual(expected[i], Nand[i].ToBool());
            }
        }
    }
}