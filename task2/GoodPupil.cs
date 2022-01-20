using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string fName, string lName)
            : base(fName, lName) { }

        public override void Study()
        {
            Console.Write("good");
            base.Study();
        }
        public override void Read()
        {
            Console.Write("good");
            base.Read();
        }
        public override void Write()
        {
            Console.Write("good");
            base.Write();
        }
        public override void Relax()
        {
            Console.Write("good");
            base.Relax();
        }
    }
}
