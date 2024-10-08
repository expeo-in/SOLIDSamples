//using SOLIDSamples.OCP.Problem;
using SOLIDSamples.OCP.Solution;

namespace SOLIDSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OCP
            var circle = new Circle(10);
            var shapeCalculator = new ShapeCalculator();
            shapeCalculator.CalculateArea(circle);
        }
    }
}
