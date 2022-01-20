using System;
using System.Collections.Generic;

namespace aditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Printer> printerCollection = new List<Printer>();
            DerivedPrinter a = new DerivedPrinter();
            DerivedPrinter2 b = new DerivedPrinter2();
            DerivedPrinter3 c = new DerivedPrinter3();
            printerCollection.Add(a as Printer);
            printerCollection.Add(b as Printer);
            printerCollection.Add(c as Printer);

            foreach (var printer in printerCollection)
                printer.Print("hello world!");
        }
    }
}
