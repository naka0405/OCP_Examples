namespace Open_Closed_BadEx1.Models
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
                Console.WriteLine($"{member.Name} is {member.GetRole()}");
            }
        }
    }
}