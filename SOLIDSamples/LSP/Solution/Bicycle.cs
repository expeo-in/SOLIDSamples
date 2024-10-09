using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.LSP.Solution
{
    internal class Bicycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Pedalling Cycle");
        }
    }
}
