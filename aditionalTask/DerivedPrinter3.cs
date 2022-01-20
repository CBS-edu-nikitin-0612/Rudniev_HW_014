using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aditionalTask
{
    internal class DerivedPrinter3 : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            base.Print(value);
        }
    }
}
