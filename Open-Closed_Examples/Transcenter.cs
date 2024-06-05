using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples
{
    internal class Transcenter
    {
        List<ISpaceMachine> spaceMachines { get; set; }
        public LaunchStation LaunchStation { get; set; }
        public TechicalService TechicalService { get; set; }

        public Transcenter()
        {
            spaceMachines = new List<ISpaceMachine>();
            LaunchStation = new LaunchStation();
            TechicalService = new TechicalService();
        }

        public void Add(ISpaceMachine machine)
        {
            spaceMachines.Add(machine);
        }

        public void Process(ISpaceMachine machine)
        {
            foreach (var spaceMachine in spaceMachines)
            {
                spaceMachine.Run();
            }

        }
    }
}