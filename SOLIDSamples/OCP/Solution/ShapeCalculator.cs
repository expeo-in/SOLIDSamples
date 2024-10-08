using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSamples.OCP.Solution
{
    internal class ShapeCalculator
    {
        public void CalculateArea(IShape shape)
        {
            shape.CalculateArea();
        }
    }
}
