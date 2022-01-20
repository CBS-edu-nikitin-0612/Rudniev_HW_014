using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Vehicle
    {
        protected readonly string model;
        protected int x, y;
        protected readonly int maxNumberOfPassengers;
        protected readonly double price, maxSpeed;
        protected readonly ushort yearOfIssue;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public double Price => price;
        public double MaxSpeed => maxSpeed;
        public ushort YearOfIssue => yearOfIssue;
        public string Model => model;
        public int MaxNumberOfPassengers => maxNumberOfPassengers;

        public Vehicle(string model, double price, double speed, ushort year, int maxNumbOfPas)
        {
            this.model = model;
            this.price = price;
            this.maxSpeed = speed;
            this.yearOfIssue = year;
            this.maxNumberOfPassengers = maxNumbOfPas;
        }

        public virtual void Show()
        {
            Console.WriteLine("Vehicle model: " + this.Model + ";");
            Console.WriteLine("Year of issue: " + this.YearOfIssue + ";");
            Console.WriteLine("Max speed: " + this.MaxSpeed + ";");
            Console.WriteLine("Max number of passengers: " + this.MaxNumberOfPassengers + ";");
            Console.WriteLine("Price: " + this.Price + "usd;");
        }
    }
}
