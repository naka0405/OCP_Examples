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
        }
    }
}