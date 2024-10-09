using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.LSP.Problem
{
    internal class Mechanic
    {
        public void CheckVehicle(IVehicle vehicle)
        {
            vehicle.StartEngine();
        }
    }
}
