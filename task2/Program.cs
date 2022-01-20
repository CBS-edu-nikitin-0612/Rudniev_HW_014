using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil pupil1 = new ExcelentPupil("Dima", "Orlov");
            GoodPupil pupil2 = new GoodPupil("Vlad", "Rudniev");
            GoodPupil pupil3 = new GoodPupil("Valya", "Popova");
            BadPupil pupil4 = new BadPupil("Vova", "Ivanov");

            ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);

            foreach (var pupil in classRoom.pupils)
            {
                Console.WriteLine("Name: " + pupil.FName + " " + pupil.LName);
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine(new string('_', 50));
            }
        }
    }
}
