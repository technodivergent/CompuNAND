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
            Nand nand1 = new Nand(0, 0);
            Nand nand2 = new Nand(0, 1);
            Nand nand3 = new Nand(1, 0);
            Nand nand4 = new Nand(1, 1);

            nand1.Print();
            nand2.Print();
            nand3.Print();
            nand4.Print();

            Console.ReadKey();
        }
    }
}
