using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_Aprel
{
    internal class Car : Vehicle
    {
        public int DoorCount { get; set; }
        public bool IsElctricCar { get; set; }


        public Car(string factoryName, string model, string color, double driveTime, double drivePath, int doorcount, bool iselectriccar) : base(factoryName, model, color, driveTime, drivePath)
        {
            DoorCount = doorcount;
            IsElctricCar=iselectriccar;
        }


        public override void GetInfo()
        {

            Console.WriteLine();
            Console.WriteLine($"Zavodun Adi: {FactoryName}");
            Console.WriteLine($"NV-nin Modeli: {Model}");
            Console.WriteLine($"NV-nin Rengi: {Color}");
            Console.WriteLine($"NV-nin Surulme Muddeti: {DriveTime} Saatdir.");
            Console.WriteLine($"NV-nin Getdiyi Yol: {DrivePath} Km-dir.");
            Console.WriteLine($"NV-nin Istehsal Tarixi: {ProductionDate}");
            Console.WriteLine($"NV-de Olan Qapi Sayi {DoorCount} Ededdir");
            Console.WriteLine();
            if (IsElctricCar == true)
            {
                Console.WriteLine("NV Elektrikle Hereket Edir");
            }
            else { Console.WriteLine("NV Elektrikle Hereket ETMIR"); }


        }
        public override void DefineNatureHarmness()
        {
            if(IsElctricCar == true)
            {
                Console.WriteLine("Neqliyyat Vasitesi Etraf Muhite LOW Zerer verir");
            }
            else { Console.WriteLine("Neqliyyat Vasitesi Etraf Muhite HIGH Zerer verir"); }
        }
    }
}
