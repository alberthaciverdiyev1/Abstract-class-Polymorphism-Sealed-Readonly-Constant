using System.Reflection;

namespace Task_13_Aprel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car vehicle1 = new Car("Chevrolet", "Camaro", "Red", 2, 500, 2, false);
            Car vehicle2 = new Car("Tesla", "Model X", "Blue", 4, 600, 4, true);
            Car vehicle3 = new Car("Dodge", "Challanger", "Black", 6, 200, 2, false);

            Bicycle bicycle1 = new Bicycle("Bajaj", "Pulsar", "Gray", 20, 420, "Mountain Bike");
            Bicycle bicycle2 = new Bicycle("Yamaha", "Fazer", "Blue", 12, 220, "Naked");
            Bicycle bicycle3 = new Bicycle("Bajaj", "Pulsar", "Gray", 20, 420, "City Bike");


            // vehicle1.AverageSpeed();
            // vehicle3.GetInfo();
            // vehicle3.DefineNatureHarmness();
            // bicycle1.GetInfo();
            //  bicycle1.AverageSpeed();
            //  bicycle1.DefineNatureHarmness();

            Vehicle[] vehicles = { vehicle1, vehicle2, vehicle3, bicycle1, bicycle2, bicycle3 };
            //foreach (var vehicle in vehicles)
            //{
            //    Console.WriteLine(vehicle);
            //}


