using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Plane : Vehicle
    {
        private ushort height, numbOfPassengers;
        private readonly ushort maxHeight;

        public ushort Height { get => height; set => height = value; }
        public ushort NumbOfPassengers { get => numbOfPassengers; set => numbOfPassengers = value; }
        public ushort MaxHeight => maxHeight;

        public Plane(string model, double price, double speed, ushort year, int maxNumbOfPas, ushort maxHeight)
            : base(model, price, speed, year, maxNumbOfPas) => this.maxHeight = maxHeight;

        //public override void Show()
        //{
        //    base.Show();
        //    Console.WriteLine("Max height flight: " + this.MaxHeight + "m;");
        //}
        public override string ToString()
        {
            return base.ToString() + "Max height flight: " + this.MaxHeight + "m;\n";
        }
    }
}
