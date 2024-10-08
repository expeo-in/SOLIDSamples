using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.OCP.Problem
{
    internal class Circle : IShape
    {
        public double Radius { get; init; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Render()
        {
            Console.WriteLine("Rendering circle");
        }
    }
}
