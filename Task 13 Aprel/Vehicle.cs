using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_Aprel
{
    abstract class Vehicle
    {
        public string FactoryName;
        public string Model;
        public string Color;
        public double DriveTime;
        public double DrivePath;
        public readonly DateTime ProductionDate;

        public Vehicle(string factoryName, string model, string color, double driveTime, double drivePath)
        {
            FactoryName = factoryName;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            DrivePath = drivePath;
            ProductionDate = DateTime.Now;

        }
        public void AverageSpeed()
        {

            double AverageSpeed = DrivePath / DriveTime;
            Console.WriteLine($"NV-nin Sureti {AverageSpeed} Km/Saat-dir.");
        }
        public abstract void GetInfo();
        public abstract void DefineNatureHarmness();
        public override string ToString()
        {
            return $"Zavod adi: {FactoryName} , Model adi: {Model}";
        }
    }
}
