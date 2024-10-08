using SOLIDSamples.OCP.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.OCP.Solution
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

        public void CalculateArea()
        {
            Console.WriteLine(3.14 * this.Radius * this.Radius);
        }
    }
}
