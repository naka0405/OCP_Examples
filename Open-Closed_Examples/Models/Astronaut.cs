using Open_Closed_Examples.Interfaces;
using Open_Closed_Examples.Models.Roles;

namespace Open_Closed_Examples.Models
{
    public class Astronaut : IPerson, IAstronaut
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public TeamRole Role { get; set; }

        public Astronaut(string name, int age, TeamRole role)
        {
            Name = name;
            Age = age;
            Role = role;
        }
    }
}
