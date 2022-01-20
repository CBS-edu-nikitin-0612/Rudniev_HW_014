using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aditionalTask
{
    class DerivedPrinter2 : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            base.Print(value);
        }
    }
}
