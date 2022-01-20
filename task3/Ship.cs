using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Ship : Vehicle
    {
        private ushort numbOfPassengers;
        private readonly string port;

        public string Port => port;
        public ushort NumbOfPassengers { get => numbOfPassengers; set => numbOfPassengers = value; }

        public Ship(string model, double price, double speed, ushort year, int maxNumbOfPas, string port)
            : base(model, price, speed, year, maxNumbOfPas) => this.port = port;

        //public override void Show()
        //{
        //    base.Show();
        //    Console.WriteLine("Home port ship: " + this.Port + ";");
        //}
        public override string ToString()
        {
            return base.ToString() + "Home port ship: " + this.Port + ";\n";
        }
    }
}
