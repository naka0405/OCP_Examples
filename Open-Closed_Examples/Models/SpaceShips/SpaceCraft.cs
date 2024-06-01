using Open_Closed_Examples.Interfaces;
using Open_Closed_Examples.Models.Engines;

namespace Open_Closed_Examples.Models.SpaceShips
{
    public class SpaceCraft
    {
        public string SerialNumber { get; set; }
        public Crew? Crew { get; set; }
        IRocketEngine? engine { get; set; }

        public SpaceCraft(string serialNumber)
        {
            SerialNumber = serialNumber;
        }

        public void SetEngine(IRocketEngine someEngine)
        {
            engine = someEngine;
        }

        internal void Process()
        {
            engine?.Process();
        }
    }
}