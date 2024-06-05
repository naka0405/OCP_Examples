using Helper;

namespace Open_Closed_Examples
{
    public abstract class System
    {
        public abstract string Name { get; }
        protected abstract double FuelConsumptionPerHour { get; }
        public bool IsActive { get; set; }
        protected DateTime StartDatetime { get; set; }

        protected SortedList<DateTime, DateTime> Schedule { get; set; }

        public System(DateTime startDateTime)
        {
            IsActive = true;
            Schedule = new SortedList<DateTime, DateTime>();
            StartDatetime = startDateTime;
        }

        public double GetCurrentConsumption()
        {
            var activeTime = GetActiveTime();

            var randomUnexpectedConsumption = Math.Round(Utils.GetRandomDouble(), 2);
            return (activeTime.TotalHours * FuelConsumptionPerHour) + randomUnexpectedConsumption;
        }

        public double GetPlannedConsumption()
        {
            var activeTime = GetActiveTime();
            return activeTime.TotalHours * FuelConsumptionPerHour;
        }

        internal TimeSpan GetActiveTime()
        {
            TimeSpan time = default;
            foreach (var span in Schedule)
            {
                time += span.Value - span.Key;
            }

            if(IsActive)
            {
                time += DateTime.UtcNow - StartDatetime;
            }

            return time;
        }

        internal void SuspendWork()
        {
            IsActive = false;
            Schedule.Add(StartDatetime, DateTime.UtcNow);
        }

        internal void StartWork()
        {
            IsActive = true;
            StartDatetime = DateTime.UtcNow;
        }
    }
}