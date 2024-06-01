using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.Engines
{
    internal class LiquidFuelEngine : IRocketEngine
    {
        public void Process()
        {
            Console.WriteLine("Liquid fuel engine started.");
        }
    }
}