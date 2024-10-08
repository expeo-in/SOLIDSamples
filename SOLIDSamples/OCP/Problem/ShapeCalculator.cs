using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.OCP.Problem
{
    internal class ShapeCalculator
    {
        public void CalculateArea(IShape shape)
        {
            if(shape is Circle circle)
            {
                Console.WriteLine(3.14 * circle.Radius * circle.Radius);
            }
            else if(shape is Rectangle rect)
            {
                Console.WriteLine(rect.Width * rect.Height);
            }
        }
    }
}
