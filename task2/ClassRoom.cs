using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class ClassRoom
    {
        public List<Pupil> pupils = new List<Pupil>();

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            this.pupils.Add(pupil1);
            this.pupils.Add(pupil2);
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
            : this(pupil1, pupil2) => this.pupils.Add(pupil3);
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
            : this(pupil1, pupil2, pupil3) => this.pupils.Add(pupil4);
    }
}
