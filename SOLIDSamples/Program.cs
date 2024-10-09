//using SOLIDSamples.OCP.Problem;
using SOLIDSamples.LSP;
using SOLIDSamples.OCP.Solution;

namespace SOLIDSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OCP
            //var circle = new Circle(10);
            //var shapeCalculator = new ShapeCalculator();
            //shapeCalculator.CalculateArea(circle);

            //LSP
            
            //Problem
            //var bicycle = new LSP.Problem.Bicycle();
            //var mechanic = new LSP.Problem.Mechanic();
            //mechanic.CheckVehicle(bicycle);

            //Solution
            var bicycle = new LSP.Solution.Bicycle();
            var mechanic = new LSP.Solution.Mechanic();
            mechanic.CheckVehicle(bicycle);
        }
    }
}
