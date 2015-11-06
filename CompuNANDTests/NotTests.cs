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
    public class NotTests
    {
        [TestMethod()]
        public void NotTest()
        {
            // Initialize objects to test
            Not[] Not = {
                new Not(0),
                new Not(1)
            };

            // Expected truth table for this object
            bool[] expected = {
                true,
                false
            };

            // Iterate through the instance and expected arrays
            for (int i = 0; i < Not.Length; i++)
            {
                Assert.AreEqual(expected[i], Not[i].ToBool());
            }
}
    }
}