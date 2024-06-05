using Open_Closed_Examples.Interfaces;
using Open_Closed_Examples.Models.Engines;

namespace Open_Closed_Examples.Models.SpaceShips
{
    internal class SpaceShip
    {
        public SpaceShip(string serialNumber)
        {
            SerialNumber = serialNumber;
        }

        public string SerialNumber { get; set; }
        public Crew? Crew { get; set; }
        public IMultiEngineService? EngineService { get; set; }

        public void SetEngineService(IMultiEngineService engineService)
        {
            EngineService = engineService;
        }

        internal void LetsGo()
        {
            EngineService?.Process();
        }
    }
}