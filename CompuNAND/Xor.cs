using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    public class Xor : LogicGate
    {
        public Xor(LogicGate LG1, LogicGate LG2)
        {
            bool p = LG1.ToBool();
            bool q = LG2.ToBool();
            this.c = XOR(p, q);
        }

        public Xor(bool p, bool q)
        {
            this.c = XOR(p, q);
        }

        public Xor(int a, int b)
        {
            bool p = Convert.ToBoolean(a);
            bool q = Convert.ToBoolean(b);
            this.c = XOR(p, q);
        }

        private bool XOR(bool p, bool q)
        {
            Or OR = new Or(p, q);
            Nand NAND = new Nand(p, q);
            And AND = new And(OR, NAND);

            bool z = AND.ToBool();
            return z;
        }
    }
}
