using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuNAND
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("NAND");
            Nand nand1 = new Nand(0, 0);
            Nand nand2 = new Nand(0, 1);
            Nand nand3 = new Nand(1, 0);
            Nand nand4 = new Nand(1, 1);

            nand1.WriteLine();
            nand2.WriteLine();
            nand3.WriteLine();
            nand4.WriteLine();

            Console.WriteLine("\nNOT");

            Not not1 = new Not(0);
            Not not2 = new Not(1);
            not1.WriteLine();
            not2.WriteLine();

            Console.WriteLine("\nAND");

            And and1 = new And(0, 0);
            And and2 = new And(0, 1);
            And and3 = new And(1, 0);
            And and4 = new And(1, 1);

            and1.WriteLine();
            and2.WriteLine();
            and3.WriteLine();
            and4.WriteLine();

            Console.WriteLine("\nOR");

            Or or1 = new Or(0, 0);
            Or or2 = new Or(0, 1);
            Or or3 = new Or(1, 0);
            Or or4 = new Or(1, 1);

            or1.WriteLine();
            or2.WriteLine();
            or3.WriteLine();
            or4.WriteLine();

            Console.WriteLine("\nXOR");

            Xor Xor1 = new Xor(0, 0);
            Xor Xor2 = new Xor(0, 1);
            Xor Xor3 = new Xor(1, 0);
            Xor Xor4 = new Xor(1, 1);

            Xor1.WriteLine();
            Xor2.WriteLine();
            Xor3.WriteLine();
            Xor4.WriteLine();

            Console.WriteLine("\nNOR");

            Nor Nor1 = new Nor(0, 0);
            Nor Nor2 = new Nor(0, 1);
            Nor Nor3 = new Nor(1, 0);
            Nor Nor4 = new Nor(1, 1);

            Nor1.WriteLine();
            Nor2.WriteLine();
            Nor3.WriteLine();
            Nor4.WriteLine();

            Console.WriteLine("\nMUX");

            Mux Mux1 = new Mux(0, 0, 0);
            Mux Mux2 = new Mux(0, 1, 0);
            Mux Mux3 = new Mux(1, 0, 0);
            Mux Mux4 = new Mux(1, 1, 0);

            Mux Mux5 = new Mux(0, 0, 1);
            Mux Mux6 = new Mux(0, 1, 1);
            Mux Mux7 = new Mux(1, 0, 1);
            Mux Mux8 = new Mux(1, 1, 1);

            Mux1.WriteLine();
            Mux2.WriteLine();
            Mux3.WriteLine();
            Mux4.WriteLine();
            Console.WriteLine("---------");
            Mux5.WriteLine();
            Mux6.WriteLine();
            Mux7.WriteLine();
            Mux8.WriteLine();

            Console.ReadKey();
        }
    }
}
