namespace Open_Closed_Examples.Models
{
    public class Crew
    {
        public List<Astronaut> TeamMembers { get; }
        public Crew()
        {
            TeamMembers = new List<Astronaut>();
        }

        public void GetAllMembers()
        {
            foreach (var member in TeamMembers)
            {
                Console.WriteLine($"{member.Person.Name} is {member.GetRole()}");
            }
        }
    }
}