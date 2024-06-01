using Open_Closed_BadEx1.Models;
using Astronaut = Open_Closed_BadEx1.Models.Astronaut;

namespace Open_Closed_BadEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            var rocket = new Rocket("OCP_Rocket");

            var crew = new Crew("OCP_Team");

            var engineer = new Astronaut("NK", 38, "engineer");
            var aircraftMechanic = new Astronaut("James Arnb", 35, "Aircraft Mechanic");
            var astromomer = new Astronaut("Ana Ree", 35, "Astronomer");

            crew.TeamMembers.Add(engineer);
            crew.TeamMembers.Add(aircraftMechanic);
            crew.TeamMembers.Add(astromomer);

            rocket.Crew = crew;
            rocket.Crew.GetAllMembers();

            // Add rocket engine           
            SetSeparator();
            rocket.Engine = new RocketEngine();
            rocket.Start();
        }

        static void SetSeparator()
        {
            Console.WriteLine(new String('-', 24));
        }
    }
}
