using Open_Closed_Examples.Models.Communication;

namespace Open_Closed_Examples
{
    internal class EnergyService
    {
        DateTime startDatetime;
        double startVolume;
        IDictionary<string, System> spaceShipSystems;

        public EnergyService(double startVolume)
        {
            startDatetime = DateTime.UtcNow.AddDays(-5);
            this.startVolume = startVolume;
            spaceShipSystems = new Dictionary<string, System>() {
                { nameof(PowerSupplySystem), new PowerSupplySystem(startDatetime) },
                { nameof(TemperatureControlSystem), new TemperatureControlSystem(startDatetime) },
                { nameof(CommunicationBlock), new CommunicationBlock(startDatetime) }
            };
        }

        public string GetCurrentState()
        {
            var activeSystems = spaceShipSystems.Where(s => s.Value.IsActive == true).ToList();
            activeSystems.ForEach(s => Console.WriteLine(s.Key));

            return $"Start volume was - {startVolume}. Current consumption is - {GetCurrentConsumption()}.\n" +
                $"Planned consumption is - {GetPlannedConsumption()}.\n" +
                $"There are {activeSystems.Count} systems are currently working.\n" +
                $"Do you want to turn off one of the systems and reduce energy? y/n";
        }

        public void AddNewSystem(string name, System newSystem)
        {
            spaceShipSystems.Add(name, newSystem);
            Console.WriteLine($"The new \'{name}\' system was added.");
        }

        private double GetCurrentConsumption()
        {            
            double totalCurrentConsumption = 0;

            foreach (var system in spaceShipSystems)
            {
                totalCurrentConsumption += system.Value.GetCurrentConsumption();
            }

            return Math.Round(totalCurrentConsumption, 3);
        }

        private double GetPlannedConsumption()
        {
            double totalPlannedConsumption = 0;

            foreach (var system in spaceShipSystems)
            {
                totalPlannedConsumption += system.Value.GetPlannedConsumption();
            }

            return Math.Round(totalPlannedConsumption, 3);
        }

        internal void SuspendWork(string systemName)
        {
            spaceShipSystems.TryGetValue(systemName, out var system);

            if (system != null)
            {
                system.SuspendWork();
            }

            Console.WriteLine($"System \'{systemName}\' was suspended.");
        }
    }
}