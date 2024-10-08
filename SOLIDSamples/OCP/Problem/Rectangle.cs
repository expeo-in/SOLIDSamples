using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.OCP.Problem
{
    internal class Rectangle : IShape
    {
        public double Width { get; init; }

        public double Height { get; init; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void Render()
        {
            Console.WriteLine("Rendering rectangle");
        }
    }
}
