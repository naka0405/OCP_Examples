using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples
{
    public class PowerSupplySystem : System, IPowerSupplySystem
    {
        public override string Name => nameof(PowerSupplySystem);

        public string SpecialSwitcher => "Switch off";

        protected override double FuelConsumptionPerHour => 35;

        public PowerSupplySystem(DateTime startDateTime) : base(startDateTime)
        {
                
        }
    }
}