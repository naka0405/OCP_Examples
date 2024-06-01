using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.Engines
{
    internal class SolidFuelEngine : IRocketEngine
    {
        public void Process()
        {
            Console.WriteLine("Solid fuel engine started.");
        }
    }
}
