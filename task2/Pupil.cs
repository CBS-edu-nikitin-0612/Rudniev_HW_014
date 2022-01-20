using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Pupil
    {
        private readonly string fName, lName;
        public string FName => fName;
        public string LName => lName;

        public Pupil() { }
        public Pupil(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

        public virtual void Study() => Console.WriteLine(" studies;");
        public virtual void Read() => Console.WriteLine(" reades;");
        public virtual void Write() => Console.WriteLine(" writes;");
        public virtual void Relax() => Console.WriteLine(" resting;");
    }
}
