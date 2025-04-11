using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.NET2025VTNiklasMattsson.Core.vehicles;

public class ElectricScooter : Vehicle
{
    public double BatteryRange { get; set; }
    public ElectricScooter(string brand, string model, int year, double weight, double batteryrange) : base(brand, model, year, weight)
    {
        BatteryRange = batteryrange;
    }

    public override void StartEngine()
    {
        Console.WriteLine("*Pip!* … ett mjukt elektroniskt ljud bekräftar att skotern är på.Ett svagt surrande följer – *bzzzzzz* – nästan som en viskning av el.När den rullar iväg hörs bara ett tyst *whiiirrrr* från motorn och ett litet sus från däcken mot marken.");
    }
    public override string SpecificStats()
    {
        return $"Batterikapacitet: {BatteryRange.ToString()}";
    }
}
