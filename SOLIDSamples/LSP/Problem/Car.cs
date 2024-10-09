using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.LSP.Problem
{
    internal class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Starting car");
        }
    }
}
