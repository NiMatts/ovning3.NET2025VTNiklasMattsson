using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.NET2025VTNiklasMattsson.Core.vehicles;

public class Car : Vehicle, ICleanable
{
    private bool ParkingAssist { get; set; }
    public Car(string brand, string model, int year, double weight, bool parkingassist) : base(brand, model, year, weight)
    {
        ParkingAssist = parkingassist;
    }
    public void Clean()
    {
        Console.WriteLine($"{Brand} {Model} tvättas");
    }
    public override void StartEngine()
    {
        Console.WriteLine("¡VROOOM!");
    }
    public override string SpecificStats()
    {
        return $"Har Parkeringsassistans: {ParkingAssist.ToString()}";
    }
}
