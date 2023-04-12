using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_Aprel
{
    internal class Bicycle : Vehicle
    {
        public string Type;
        public Bicycle(string factoryName, string model, string color, double driveTime, double drivePath, string type) : base(factoryName, model, color, driveTime, drivePath)
        {
            Type = type;
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
            Console.WriteLine($"NV-nin Tipi: {Type}");
            Console.WriteLine();


        }
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("Neqliyyat Vasitesi Etraf Muhite NONE Zerer Verir");
        }
    }
}
