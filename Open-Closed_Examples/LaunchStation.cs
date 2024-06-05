using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples
{
    public class LaunchStation
    {
        public void Start(IValidMachine machine)
        {
            if (machine.IsValid && machine is not ITouristShuttle)
            {
                Console.WriteLine($"3, 2, 1, {machine} started!");
            }
            else
            {
                Console.WriteLine($"WARNING! The {machine} could not be started!");
            }
        }
    }

    public class SpaceMachineProcessor
    {
        private readonly ISpaceMachine spaceMachine;

        public SpaceMachineProcessor(ISpaceMachine machine)
        {
            spaceMachine = machine;
        }

        public void Process()
        {
            spaceMachine.Run();
        }
    }
}