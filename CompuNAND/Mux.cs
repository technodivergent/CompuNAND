using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    public class Mux : LogicGate
    {
        public Mux(LogicGate LG1, LogicGate LG2, bool sel)
        {
            bool p = LG1.ToBool();
            bool q = LG2.ToBool();
            this.c = MUX(p, q, sel);
        }

        public Mux(bool p, bool q, bool sel)
        {
            this.c = MUX(p, q, sel);
        }

        public Mux(int a, int b, int i_sel)
        {
            bool p = Convert.ToBoolean(a);
            bool q = Convert.ToBoolean(b);
            bool sel = Convert.ToBoolean(i_sel);
            this.c = MUX(p, q, sel);
        }

        private bool MUX(bool p, bool q, bool sel)
        {
            Not NOTSEL = new Not(sel);
            And AND1 = new And(p, NOTSEL.ToBool());
            And AND2 = new And(q, sel);
            Or OR = new Or(AND1, AND2);

            bool z = OR.ToBool();
            return z;
        }
    }
}
