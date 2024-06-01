using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.Engines
{
    internal class ElectricEngine : IRocketEngine
    {
        public void Process()
        {
            Console.WriteLine("Electric engine started.");
        }
    }
}