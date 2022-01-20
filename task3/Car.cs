using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Car : Vehicle
    {
        private ushort numbOfPassengers;

        public ushort NumbOfPassengers { get => numbOfPassengers; set => numbOfPassengers = value; }

        public Car(string model, double price, double speed, ushort year, int maxNumbOfPas)
            : base(model, price, speed, year, maxNumbOfPas) { }

        //public override void Show() => base.Show();

        public override string ToString() => base.ToString();
    }
}
