using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ovning3.NET2025VTNiklasMattsson.Core;
using ovning3.NET2025VTNiklasMattsson.Core.errors;
using ovning3.NET2025VTNiklasMattsson.Core.vehicles;
namespace ovning3.NET2025VTNiklasMattsson;

internal class Handler
{
    public void Play()
    {
        var brakeFail = new BrakeFailureError();
        var engineFail = new EngineFailureError();
        var transmissionFail = new TransmissionError();
        var listOfErrors = new List<string> { brakeFail.ErrorMessage(), engineFail.ErrorMessage(),transmissionFail.ErrorMessage() };
        foreach (var error in listOfErrors)
        {
            Console.WriteLine(error);
        }
        var vehicles = new List<Vehicle>();
        try
        {
            vehicles.Add(new Car("", "", 1, 1.0, true));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Fel: " + ex.Message);
        }
        try
        {
            vehicles.Add(new Car("Volvo", "EXC90", 2025, 2000, true));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Fel: " + ex.Message);
        }
        vehicles.Add(new Truck("awd", "fsds", 1999, 555.0, 10));
        vehicles.Add(new Motorcycle("dsad", "fhs", 1999, 555.0, false));
        vehicles.Add(new ElectricScooter("sgdd", "fbfs", 1999, 555.0, 15.2));
        vehicles.Add(new Car("dfn", "dfh", 1999, 551.0, true));
        //var dog = new Dog(10.0);

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.Stats());
            vehicle.StartEngine();
            if (vehicle is ICleanable cleanable)
                cleanable.Clean();
            
            Console.WriteLine();
        }

        //• F: Vad händer om du försöker lägga till en Car i en lista av Motorcycle?
            //new List<Motorcycle> { new Car("dfn", "dfh", 1999, 551.0, true) };
            //funkar ej inte babushka
        //• F: Vilken typ bör en lista vara för att rymma alla fordonstyper ?
            //Vehicle
        //• F: Kommer du åt metoden Clean() från en lista med typen List<Vehicle>? 
            //Nej; inte direkt, kan dock testa för den och sedan komma åt.
        //• F: Vad är fördelarna med att använda ett interface här istället för arv?
            //Minskar kraven på implementation  
    }
}
