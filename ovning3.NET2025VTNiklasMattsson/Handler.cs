using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ovning3.NET2025VTNiklasMattsson.Core;
using ovning3.NET2025VTNiklasMattsson.Core.errors;
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
}
}
