using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ovning3.NET2025VTNiklasMattsson.Core.vehicles;

public class Truck : Vehicle, ICleanable
{
    public int BedSize { get; set; }

    public Truck(string brand, string model, int year, double weight, int bedsize) : base(brand, model, year, weight)
    {
        BedSize = bedsize;
    }
    public void Clean()
    {
        Console.WriteLine($"{Brand} {Model} tvättas");
    }
    public override void StartEngine()
    {
        Console.WriteLine("Meow!");
    }
    public override string SpecificStats()
    {
        return $"Storlek på flak: {BedSize.ToString()}";
    }
}
