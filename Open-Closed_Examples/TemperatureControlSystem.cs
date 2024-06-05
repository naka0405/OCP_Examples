namespace Open_Closed_Examples
{
    public class TemperatureControlSystem : System
    {
        public override string Name => nameof(TemperatureControlSystem);

        protected override double FuelConsumptionPerHour => 17;

        public TemperatureControlSystem(DateTime startDateTime) : base(startDateTime)
        {
        }
    }
}