using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class BadPupil : Pupil
    {
        public BadPupil(string fName, string lName)
            : base(fName, lName) { }

        public override void Study()
        {
            Console.Write("bad");
            base.Study();
        }
        public override void Read()
        {
            Console.Write("bad");
            base.Read();
        }
        public override void Write()
        {
            Console.Write("bad");
            base.Write();
        }
        public override void Relax()
        {
            Console.Write("very badly");
            base.Relax();
        }
    }
}
