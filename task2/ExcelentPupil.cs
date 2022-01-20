using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string fName, string lName)
            : base(fName, lName) { }

        public override void Study()
        {
            Console.Write("excelent");
            base.Study();
        }
        public override void Read()
        {
            Console.Write("excelent");
            base.Read();
        }
        public override void Write()
        {
            Console.Write("excelent");
            base.Write();
        }
        public override void Relax()
        {
            Console.Write("little");
            base.Relax();
        }
    }
}
