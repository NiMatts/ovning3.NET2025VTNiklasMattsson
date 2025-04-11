using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning3.NET2025VTNiklasMattsson.Core.errors
{
    public class BrakeFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Felsignal: BromsError";
        }
    }
}
