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
    public class MuxTests
    {
        [TestMethod()]
        public void MuxTest()
        {
            // Initialize objects to test
            Mux[] Mux =
            {
                new Mux(0,0,0),
                new Mux(0,1,0),
                new Mux(1,0,0),
                new Mux(1,1,0),

                new Mux(0,0,1),
                new Mux(0,1,1),
                new Mux(1,0,1),
                new Mux(1,1,1)
            };

            // Expected truth table for this object
            bool[] expected =
            {
                false,
                false,
                true,
                true,

                false,
                true,
                false,
                true
            };

            // Iterate through the instance and expected arrays
            for (int i = 0; i < Mux.Length; i++)
            {
                Assert.AreEqual(expected[i], Mux[i].ToBool());
            }
        }
    }
}