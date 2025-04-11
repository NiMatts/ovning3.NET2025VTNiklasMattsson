using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.NET2025VTNiklasMattsson.Core.vehicles;

public class Motorcycle : Vehicle, ICleanable
{
    public bool HasSidecar { get; set; }
    public Motorcycle(string brand, string model, int year, double weight, bool sidecar) : base(brand, model, year, weight)
    {
        HasSidecar = sidecar;
    }
    public void Clean()
    {
        Console.WriteLine($"{Brand} {Model} tvättas");
    }
    public override void StartEngine()
    {
        Console.WriteLine("*Klick*... *Vrrr-vrrr-vrroooom!*Motorn hostar till – *vrrr-vrrr* – sen plötsligt ett kraftigt:*BRRRAAAAPP!!*Ett dovt muller växer fram när motorn går igång – *brum-brum-brummmm* – redo att ge sig av.");
    }
    public override string SpecificStats()
    {
        return $"Har sidovagn: {HasSidecar.ToString()}";
    }
}
