using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    public class Car
    {
        public Engine Engine { get; set; }
        public string Model { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }

        public Car
            (string model,
            int engineSpeed, int enginePower,
            int cargoWeight, string cargoType,
            double tire1Pressure, double tire2Pressure, double tire3Pressure, double tire4Pressure,
            int tire1Age, int tire2Age, int tire3Age, int tire4Age)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);
            Tires = new List<Tire>();
            Tires.Add(new Tire(tire1Pressure, tire1Age));
            Tires.Add(new Tire(tire2Pressure, tire2Age));
            Tires.Add(new Tire(tire3Pressure, tire3Age));
            Tires.Add(new Tire(tire4Pressure, tire4Age));

        }
    }
}
