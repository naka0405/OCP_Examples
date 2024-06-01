namespace Open_Closed_BadEx1.Models
{
    public class Crew
    {
        public string Identifier { get; }
        public List<Astronaut> TeamMembers { get; }
        public Crew(string identifier)
        {
            TeamMembers = new List<Astronaut>();
            Identifier=identifier;
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