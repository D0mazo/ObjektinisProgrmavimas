using System;
using System.Collections.Generic;
using System.IO;

namespace Temp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\Domin\OneDrive\Desktop\BlazorApp\Temp\Masina.txt";
            string[] lines = File.ReadAllLines(file);
            var vehicleCount = int.Parse(lines[0]);
            var vehiclesList = new List<Car>();

            for (int i = 1; i <= vehicleCount; i++)
            {
                var vehicleInformation = lines[i].Split(' ');

                var model = vehicleInformation[0];
                var engineSpeed = int.Parse(vehicleInformation[1]);
                var enginePower = int.Parse(vehicleInformation[2]);
                var cargoWeight = int.Parse(vehicleInformation[3]);
                var cargoType = vehicleInformation[4];
                var tire1Pressure = double.Parse(vehicleInformation[5]);
                var tire1Age = int.Parse(vehicleInformation[6]);
                var tire2Pressure = double.Parse(vehicleInformation[7]);
                var tire2Age = int.Parse(vehicleInformation[8]);
                var tire3Pressure = double.Parse(vehicleInformation[9]);
                var tire3Age = int.Parse(vehicleInformation[10]);
                var tire4Pressure = double.Parse(vehicleInformation[11]);
                var tire4Age = int.Parse(vehicleInformation[12]);

                var car = new Car(model, engineSpeed, enginePower,
                    cargoWeight, cargoType,
                    tire1Pressure, tire2Pressure, tire3Pressure, tire4Pressure,
                    tire1Age, tire2Age, tire3Age, tire4Age);

                vehiclesList.Add(car);
            }

            BadTires(vehiclesList);
            CarPower(vehiclesList);
        }

        static void BadTires(List<Car> cars)
        {
            foreach (var car in cars)
            {
                foreach (var tire in car.Tires)
                {
                    if (tire.Pressure < 1)
                    {
                        Console.WriteLine($"Bad Car Pressure {car.Model}");
                        
                    }
                }
            }
        }
        static void CarPower(List<Car> cars)
        {
            foreach (var car in cars)
            {
               if (car.Engine.Power > 250)
                    {
                        Console.WriteLine($"Car with enginePowere more than 250 {car.Model}");
                        
                    }
                }
            }
        }
    }

